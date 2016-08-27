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
        private int timeout;
        private bool noTimeout;
        private bool tryOpenPlayer;

        private Queue<TwitchDownload> chunks;

        private volatile bool isStreamStarted;
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
            panelTimeoutSettings.Enabled = false;
            panelPlayerSettings.Enabled = false;

            bufferSize = trackBarBufferSize.Value;
            timeout = Convert.ToInt32(numericUpDownTimeout.Value);
            noTimeout = checkBoxTimeout.Checked;
            tryOpenPlayer = checkBoxPlayerReopen.Checked;

            OpenStream();
        }
        private void buttonCloseStream_Click(object sender, EventArgs e)
        {
            buttonCloseStream.Enabled = false;
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
            TwitchStreamState streamState;
            qualityPlaylist = null;

            streamState = await this.GetStreamState(textBoxOpenStream.Text);

            if ( streamState == TwitchStreamState.OK )
            {
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
                }
            }
            else
            {
                CloseStream();
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
            panelTimeoutSettings.Enabled = true;
            panelPlayerSettings.Enabled = true;
        }

        private async void Play()
        {

            string url = selectedQuality.url;
            string lastindex = string.Empty;
            int startLine = 8;
            bool timeoutStarted = false;

            while ( isStreamDownloading )
            {
                try
                {
                    while ( isStreamDownloading )
                    {
                        string response = await httpClient.GetStringAsync(url);
                        string[] playlist = M3U8.Build(response);
                        if ( lastindex == string.Empty )
                        {
                            lastindex = playlist[16]; //?
                        }
                        bool isLastFound = false;
                        for ( int i = 0; i < 6; i++ )
                        {
                            string chunkName = playlist[startLine + (i * 2)];
                            if ( !isLastFound )
                            {
                                if ( lastindex != chunkName )
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
                        lastindex = playlist[18];
                        Thread.Sleep(1000);
                    }
                }
                catch ( Exception e )
                {
                    Console.WriteLine(e.ToString());
                    if ( !noTimeout )
                    {
                        if ( timeoutStarted )
                        {
                            isStreamDownloading = false;
                            break;
                        }
                        else
                        {
                            timeoutStarted = true;
                            Thread.Sleep(timeout);
                        }
                    }
                }
            }

            lock ( chunks )
            {
                chunks.Clear();
            }

            isStreamStopped = true;
        }

        private async void StartWrite()
        {
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
            while ( isStreamDownloading )
            {
                try
                {
                    MPCBEPlayer player = new MPCBEPlayer();
                    player.Start();
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
                catch ( Exception e )
                {
                    Console.WriteLine(e.ToString());
                    if ( !tryOpenPlayer )
                    {
                        isStreamDownloading = false;
                        break;
                    }
                }
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
                + "/access_token";

            string response;

            try
            {
                response = await httpClient.GetStringAsync(path);
            }
            catch
            {
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

        private async Task<TwitchStreamState> GetStreamState(string channelName)
        {
            TwitchStream streamInfo = await GetStream(channelName);
            if ( streamInfo == null )
            {
                labelState.Text = "Stream is not found \nor internet connection problem";
                return TwitchStreamState.NotFound;
            }
            else if ( streamInfo.stream == null )
            {
                labelState.Text = "Stream is not online";
                return TwitchStreamState.NotOnline;
            }
            else
            {
                labelState.Text = "Stream is online";
                return TwitchStreamState.OK;
            }
        }
        private async Task<TwitchStream> GetStream(string channelName)
        {
            Uri site = new Uri("https://api.twitch.tv/kraken/streams/" + channelName.ToLower());
            try
            {
                string STR = await httpClient.GetStringAsync(site);
                TwitchStream twitchStream = Utility.Deserialize<TwitchStream>(STR);
                return twitchStream;
            }
            catch
            {
                return null;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            httpClient = new HttpClient();
            chunks = new Queue<TwitchDownload>();
            ReadFavorites();
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
            string[] items = new string[listBoxFavorite.Items.Count];
            int i = 0;

            foreach ( string item in listBoxFavorite.Items )
            {
                items[i] = item;
                i++;
            }
            File.WriteAllLines("favorites.txt", items);
        }
        private void ReadFavorites()
        {
            if(File.Exists("favorites.txt") )
            {
                using ( StreamReader sr = File.OpenText("favorites.txt") )
                {
                    string str = String.Empty;
                    while ( (str = sr.ReadLine()) != null )
                    {
                        listBoxFavorite.Items.Add(str);
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxTimeout_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxTimeout.Checked)
            {
                numericUpDownTimeout.Enabled = false;
            }
            else
            {
                numericUpDownTimeout.Enabled = true;
            }
        }
    }
}
