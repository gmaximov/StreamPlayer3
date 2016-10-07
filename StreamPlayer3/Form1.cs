using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamPlayer3
{
    public partial class StreamPlayer3 : Form
    {
        private HttpClient httpClient;

        private Dictionary<string, TwitchQuality> qualityPlaylist;
        private TwitchQuality selectedQuality;

        private int bufferSize;

        private Queue<TwitchDownload> chunks;

        private volatile bool isStreamDownloading;
        private volatile bool isStreamStopped;

        public StreamPlayer3()
        {
            InitializeComponent();
        }

        private void buttonOpenStream_Click(object sender, EventArgs e)
        {
            labelState.Text = string.Empty;


            //block controls
            buttonOpenStream.Enabled = false;
            textBoxOpenStream.Enabled = false;
            panelBufferSize.Enabled = false;

            bufferSize = trackBarBufferSize.Value;

            OpenStream();
        }
        private void buttonCloseStream_Click(object sender, EventArgs e)
        {
            buttonCloseStream.Enabled = false;
            buttonChat.Enabled = false;
            panelPlay.Enabled = false;

            CloseStream();
            labelState.Text = string.Empty;
        }

        private async void buttonPlay_Click(object sender, EventArgs e)
        {
            isStreamDownloading = true;
            panelOpenStream.Enabled = false;
            buttonPlay.Enabled = false;
            listBoxQualityPlaylist.Enabled = false;
            buttonStop.Enabled = true;

            selectedQuality = qualityPlaylist[listBoxQualityPlaylist.SelectedItem.ToString()];

            isStreamStopped = false;

            Task task1 = Task.Run((Action) Play);
            Task task2 = Task.Run((Action) StartWrite);

            while ( !isStreamStopped )
            {
                await Task.Delay(1000);
            }

            buttonStop.Enabled = false;
            panelOpenStream.Enabled = true;
            listBoxQualityPlaylist.Enabled = true;
            buttonPlay.Enabled = true;
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStop.Enabled = false;
            isStreamDownloading = false;
        }

        private async void OpenStream()
        {
            string channelName = textBoxOpenStream.Text;

            qualityPlaylist = await this.GetQualityPlaylist(channelName);
            if ( qualityPlaylist == null )
            {
                CloseStream();
            }
            else
            {
                listBoxQualityPlaylist.Items.Clear();
                foreach ( string qualityName in qualityPlaylist.Keys )
                {
                    listBoxQualityPlaylist.Items.Add(qualityName);
                }
                listBoxQualityPlaylist.SelectedIndex = 0;

                panelPlay.Enabled = true;
                buttonCloseStream.Enabled = true;
                buttonChat.Enabled = true;
            }
        }
        private void CloseStream()
        {
            // stop download, clear playlist and disable Play control
            qualityPlaylist = null;
            listBoxQualityPlaylist.Items.Clear();

            //activate controls
            textBoxOpenStream.Enabled = true;
            buttonOpenStream.Enabled = true;
            panelBufferSize.Enabled = true;
        }

        private async void Play()
        {

            string url = selectedQuality.url;
            string lastindex = string.Empty;
            int startLine = 9;
            try
            {
                while ( isStreamDownloading )
                {
                    string response = await httpClient.GetStringAsync(url);
                    string[] playlist = M3U8.Build(response);
                    if ( lastindex == string.Empty )
                    {
                        lastindex = playlist[19]; //?
                    }
                    bool isLastFound = false;
                    for ( int i = 0; i < 6; i++ )
                    {
                        string chunkName = playlist[startLine + (i * 2)];
                        if( !isLastFound)
                        {
                            if ( lastindex != chunkName)
                            {
                                continue;
                            }
                            else
                            {
                                isLastFound = true;
                                continue;
                            }
                        }
                        lastindex = chunkName;
                        string chunkPath = url.ToString().Replace("index-live.m3u8", chunkName);
                        byte[] chunk = await httpClient.GetByteArrayAsync(chunkPath);
                        lock ( chunks )
                        {
                            chunks.Enqueue(new TwitchDownload(chunkName, chunk));
                        }
                    }
                    lastindex = playlist[19];
                    Thread.Sleep(1000);
                }
            }
            catch
            {
                isStreamDownloading = false;
            }

            lock ( chunks )
            {
                chunks.Clear();
            }

            isStreamStopped = true;
        }

        private async void StartWrite()
        {
            int bufferSize = this.bufferSize;
            int wait = bufferSize * 1000 + 1000;

            while (true)
            {
                lock ( chunks )
                {
                    if ( chunks.Count >= bufferSize )
                    {
                        break;
                    }
                }
                Thread.Sleep(wait);
            }

            Player player = new Player();
            player.Start();

            try
            {
                while ( isStreamDownloading )
                {
                    byte[] chunk = null;
                    lock ( chunks )
                    {
                        if ( chunks.Count > 0 )
                        {
                            chunk = chunks.Dequeue().chunk;
                        }
                    }
                    if ( chunk != null )
                    {
                        await player.WriteByteArray(chunk);
                    }
                    Thread.Sleep(1000);
                }
                player.Close();
            }
            catch
            {
                isStreamDownloading = false;
            }
        }

        private async Task<Dictionary<string, TwitchQuality>> GetQualityPlaylist(string channelName)
        {
            TwitchAccessToken accessToken;

            try
            {
                accessToken = await GetAccessToken(channelName);
            }
            catch
            {
                return null;
            }

            if (accessToken == null )
            {
                return null;
            }

            Uri site = new Uri("http://usher.twitch.tv/api/channel/hls/"
                + channelName.ToLower()
                + ".m3u8?player=twitchweb&token="
                + ""
                + accessToken.token
                + "&sig="
                + accessToken.sig
                + "&allow_audio_only=true&allow_source=true&type=any&p=121222");

            string response;

            try
            {
                response = await httpClient.GetStringAsync(site);
            }
            catch
            {
                return null;
            }

            string[] qualityPlaylist = M3U8.Build(response);

            return ParseQualityPlaylist(qualityPlaylist);
        }
        private async Task<TwitchAccessToken> GetAccessToken(string channelName)
        {
            string path;

            path = "http://api.twitch.tv/api/channels/"
                + channelName.ToLower()
                + "/access_token.json?oauth_token=qflco99t368mdeu5o04vx1eaw4tz52";
           
            string response;

            try
            {
                response = await httpClient.GetStringAsync(path);
            }
            catch
            {
                Console.WriteLine("error");
                return null;
            }

            TwitchAccessToken accessToken = Utility.Deserialize<TwitchAccessToken>(response);
            return accessToken;
        }
        private Dictionary<string, TwitchQuality> ParseQualityPlaylist(string[] qualityPlaylist)
        {
            Dictionary<string, TwitchQuality> parsedPlaylist = new Dictionary<string, TwitchQuality>();
            int startLine = 2;
            int currentLine = startLine;
            while ( (currentLine + 5) < qualityPlaylist.Length )
            {
                string name;
                string resolution;
                string url;
                int bitrate;

                name = qualityPlaylist[currentLine]
                    .Split(':')[1]
                    .Split(',')[2]
                    .Split('=')[1]
                    .Replace("\"", "");

                string[] parameters = qualityPlaylist[currentLine + 1]
                    .Split(':')[1]
                    .Split(',');

                resolution = parameters[2].Split('=')[1].Replace("\"", "");

                bool parsed = Int32.TryParse(parameters[1].Split('=')[1].Replace("\"", ""), out bitrate);
                if ( !parsed )
                {
                    throw new Exception("SOMETHING BAD HAPPEN WHILE PARSING " + parameters[1].Replace("\"", "") + " to INT");
                }
                bitrate = bitrate / 1024;

                url = qualityPlaylist[currentLine + 2];

                parsedPlaylist.Add(name + " (" + resolution + ") " + bitrate + "kbps", new TwitchQuality(name, resolution, bitrate, url));
                currentLine = currentLine + 3;
            }
            return parsedPlaylist;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            httpClient = new HttpClient();
            chunks = new Queue<TwitchDownload>();

            Config.Load();

            ReadConfig();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelBufferSizeValue.Text = (trackBarBufferSize.Value).ToString();
        }

        private void listBoxFavorite_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = (string) listBoxFavorite.SelectedItem;
            if ( selected != null )
            {
                textBoxOpenStream.Text = selected;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if ( (textBoxOpenStream.Text != string.Empty) && (!listBoxFavorite.Items.Contains(textBoxOpenStream.Text)) )
            {
                listBoxFavorite.Items.Add(textBoxOpenStream.Text);
                WriteFavorites();
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if( listBoxFavorite.SelectedIndex >= 0 )
            {
                listBoxFavorite.Items[listBoxFavorite.SelectedIndex] = textBoxOpenStream.Text;
                WriteFavorites();
            }
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if ( listBoxFavorite.SelectedIndex >= 0 )
            {
                listBoxFavorite.Items.RemoveAt(listBoxFavorite.SelectedIndex);
                WriteFavorites();
            }
        }

        private void WriteFavorites()
        {
            Config.favorites.Clear();
            foreach ( string item in listBoxFavorite.Items )
            {
                Config.favorites.Add(item);
            }
            Config.Save();
        }

        private void ReadConfig()
        {
            textBoxPlayerPath.Text = Config.playerPath;
            textBoxPlayerArgs.Text = Config.playerArgs;

            listBoxFavorite.Items.Clear();
            if ( !TryReadOldFavs() )
            {
                listBoxFavorite.Items.AddRange(Config.favorites.ToArray());
            }
        }

        private bool TryReadOldFavs()
        {
            if ( File.Exists("favorites.txt") )
            {
                using ( StreamReader sr = File.OpenText("favorites.txt") )
                {
                    string str = String.Empty;
                    while ( (str = sr.ReadLine()) != null )
                    {
                        listBoxFavorite.Items.Add(str);
                    }
                }
                WriteFavorites();
                File.Delete("favorites.txt");
                return true;
            }
            else
            {
                return false;
            }

        }

        private async void checkUpdateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string version = "000000000007";
            string new_version_path = "https://raw.githubusercontent.com/gmaximov/StreamPlayer3/master/StreamPlayer3/version.txt";

            string new_version = await httpClient.GetStringAsync(new_version_path);

            if (version != new_version)
            {
                if ( MessageBox.Show("New version available. Would you like to download it?", "Version check", MessageBoxButtons.YesNo) == DialogResult.Yes )
                {
                    System.Diagnostics.Process.Start("https://github.com/gmaximov/StreamPlayer3/releases/latest");
                }
            }
            else
            {
                MessageBox.Show("You have latest version.", "Version check");
            }
        }

        private void buttonChat_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.twitch.tv/" + textBoxOpenStream.Text + "/chat?popout=");
        }

        private void toolStripMenuItemConfig_Click(object sender, EventArgs e)
        {

            panelConfig.Visible = true;
        }

        private void buttonPlayerPath_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";

            if ( openFileDialog1.ShowDialog() == DialogResult.OK )
            {
                textBoxPlayerPath.Text = openFileDialog1.FileName;
            }
        }

        private void buttonConfigReset_Click(object sender, EventArgs e)
        {
            textBoxPlayerPath.Text = @"MPC-BE\mpc-be.exe";
            textBoxPlayerArgs.Text = @"-";           
        }

        private void buttonConfigSave_Click(object sender, EventArgs e)
        {
            buttonConfigSave.Enabled = false;

            Config.playerPath = textBoxPlayerPath.Text;
            Config.playerArgs = textBoxPlayerArgs.Text;
            Config.Save();

            panelConfig.Visible = false;
        }

        private void buttonConfigClose_Click(object sender, EventArgs e)
        {
            panelConfig.Visible = false;
        }

        private void textBoxPlayerPath_TextChanged(object sender, EventArgs e)
        {
            buttonConfigSave.Enabled = true;
        }

        private void textBoxPlayerCommandLine_TextChanged(object sender, EventArgs e)
        {
            buttonConfigSave.Enabled = true;
        }
    }
}
