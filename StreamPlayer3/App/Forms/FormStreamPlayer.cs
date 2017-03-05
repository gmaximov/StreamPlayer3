using StreamPlayer3.App.Plugins.Twitch;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamPlayer.App.Forms
{
    public partial class FormStreamPlayer : Form
    {
        public FormStreamPlayer()
        {
            InitializeComponent();
        }

        private async void checkUpdateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string version = "8";
            var httpClient = new HttpClient();
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


        private void toolStripMenuItemConfig_Click(object sender, EventArgs e)
        {
            new Settings().ShowDialog();
        }

        private void FormStreamPlayer_Load(object sender, EventArgs e)
        {
            var twitchControl = new TwitchControl();
            twitchControl.Parent = panel1;
        }
    }
}
