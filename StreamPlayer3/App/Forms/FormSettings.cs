using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamPlayer.App.Forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
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

            Close();
        }

        private void buttonConfigClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxPlayerPath_TextChanged(object sender, EventArgs e)
        {
            buttonConfigSave.Enabled = true;
        }

        private void textBoxPlayerCommandLine_TextChanged(object sender, EventArgs e)
        {
            buttonConfigSave.Enabled = true;
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            textBoxPlayerPath.Text = Config.playerPath;
            textBoxPlayerArgs.Text = Config.playerArgs;
        }
    }
}
