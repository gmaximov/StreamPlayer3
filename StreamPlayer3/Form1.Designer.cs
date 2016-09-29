using System.IO;

namespace StreamPlayer3
{
    partial class StreamPlayer3
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpenStream = new System.Windows.Forms.Button();
            this.textBoxOpenStream = new System.Windows.Forms.TextBox();
            this.trackBarBufferSize = new System.Windows.Forms.TrackBar();
            this.labelBufferSize = new System.Windows.Forms.Label();
            this.panelBufferSize = new System.Windows.Forms.Panel();
            this.labelBufferSizeValue = new System.Windows.Forms.Label();
            this.panelOpenStream = new System.Windows.Forms.Panel();
            this.buttonChat = new System.Windows.Forms.Button();
            this.labelState = new System.Windows.Forms.Label();
            this.buttonCloseStream = new System.Windows.Forms.Button();
            this.listBoxQualityPlaylist = new System.Windows.Forms.ListBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.panelPlay = new System.Windows.Forms.Panel();
            this.buttonStop = new System.Windows.Forms.Button();
            this.panelFavorite = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.listBoxFavorite = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.versionCheckToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBufferSize)).BeginInit();
            this.panelBufferSize.SuspendLayout();
            this.panelOpenStream.SuspendLayout();
            this.panelPlay.SuspendLayout();
            this.panelFavorite.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenStream
            // 
            this.buttonOpenStream.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.buttonOpenStream.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenStream.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenStream.Location = new System.Drawing.Point(-1, -1);
            this.buttonOpenStream.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOpenStream.Name = "buttonOpenStream";
            this.buttonOpenStream.Size = new System.Drawing.Size(109, 25);
            this.buttonOpenStream.TabIndex = 0;
            this.buttonOpenStream.Text = "Open stream";
            this.buttonOpenStream.UseVisualStyleBackColor = true;
            this.buttonOpenStream.Click += new System.EventHandler(this.buttonOpenStream_Click);
            // 
            // textBoxOpenStream
            // 
            this.textBoxOpenStream.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOpenStream.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOpenStream.Location = new System.Drawing.Point(-1, 23);
            this.textBoxOpenStream.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxOpenStream.Name = "textBoxOpenStream";
            this.textBoxOpenStream.Size = new System.Drawing.Size(217, 25);
            this.textBoxOpenStream.TabIndex = 1;
            // 
            // trackBarBufferSize
            // 
            this.trackBarBufferSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarBufferSize.LargeChange = 1;
            this.trackBarBufferSize.Location = new System.Drawing.Point(0, 23);
            this.trackBarBufferSize.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarBufferSize.Maximum = 30;
            this.trackBarBufferSize.Minimum = 1;
            this.trackBarBufferSize.Name = "trackBarBufferSize";
            this.trackBarBufferSize.Size = new System.Drawing.Size(215, 45);
            this.trackBarBufferSize.TabIndex = 7;
            this.trackBarBufferSize.Value = 1;
            this.trackBarBufferSize.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // labelBufferSize
            // 
            this.labelBufferSize.AutoSize = true;
            this.labelBufferSize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBufferSize.Location = new System.Drawing.Point(3, 3);
            this.labelBufferSize.Margin = new System.Windows.Forms.Padding(0);
            this.labelBufferSize.Name = "labelBufferSize";
            this.labelBufferSize.Size = new System.Drawing.Size(71, 17);
            this.labelBufferSize.TabIndex = 8;
            this.labelBufferSize.Text = "Buffer size:";
            // 
            // panelBufferSize
            // 
            this.panelBufferSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBufferSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBufferSize.Controls.Add(this.trackBarBufferSize);
            this.panelBufferSize.Controls.Add(this.labelBufferSize);
            this.panelBufferSize.Controls.Add(this.labelBufferSizeValue);
            this.panelBufferSize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelBufferSize.Location = new System.Drawing.Point(-1, 259);
            this.panelBufferSize.Name = "panelBufferSize";
            this.panelBufferSize.Size = new System.Drawing.Size(217, 57);
            this.panelBufferSize.TabIndex = 9;
            // 
            // labelBufferSizeValue
            // 
            this.labelBufferSizeValue.AutoSize = true;
            this.labelBufferSizeValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBufferSizeValue.Location = new System.Drawing.Point(74, 3);
            this.labelBufferSizeValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelBufferSizeValue.Name = "labelBufferSizeValue";
            this.labelBufferSizeValue.Size = new System.Drawing.Size(15, 17);
            this.labelBufferSizeValue.TabIndex = 9;
            this.labelBufferSizeValue.Text = "1";
            // 
            // panelOpenStream
            // 
            this.panelOpenStream.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOpenStream.Controls.Add(this.buttonChat);
            this.panelOpenStream.Controls.Add(this.panelBufferSize);
            this.panelOpenStream.Controls.Add(this.labelState);
            this.panelOpenStream.Controls.Add(this.buttonCloseStream);
            this.panelOpenStream.Controls.Add(this.buttonOpenStream);
            this.panelOpenStream.Controls.Add(this.textBoxOpenStream);
            this.panelOpenStream.Location = new System.Drawing.Point(235, 39);
            this.panelOpenStream.Name = "panelOpenStream";
            this.panelOpenStream.Size = new System.Drawing.Size(217, 317);
            this.panelOpenStream.TabIndex = 12;
            // 
            // buttonChat
            // 
            this.buttonChat.Enabled = false;
            this.buttonChat.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.buttonChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChat.Location = new System.Drawing.Point(-1, 47);
            this.buttonChat.Margin = new System.Windows.Forms.Padding(0);
            this.buttonChat.Name = "buttonChat";
            this.buttonChat.Size = new System.Drawing.Size(217, 25);
            this.buttonChat.TabIndex = 21;
            this.buttonChat.Text = "Open chat";
            this.buttonChat.UseVisualStyleBackColor = true;
            this.buttonChat.Visible = false;
            this.buttonChat.Click += new System.EventHandler(this.buttonChat_Click);
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelState.Location = new System.Drawing.Point(-1, 48);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(0, 17);
            this.labelState.TabIndex = 20;
            // 
            // buttonCloseStream
            // 
            this.buttonCloseStream.Enabled = false;
            this.buttonCloseStream.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.buttonCloseStream.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseStream.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseStream.Location = new System.Drawing.Point(107, -1);
            this.buttonCloseStream.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCloseStream.Name = "buttonCloseStream";
            this.buttonCloseStream.Size = new System.Drawing.Size(109, 25);
            this.buttonCloseStream.TabIndex = 19;
            this.buttonCloseStream.Text = "Close stream";
            this.buttonCloseStream.UseVisualStyleBackColor = true;
            this.buttonCloseStream.Click += new System.EventHandler(this.buttonCloseStream_Click);
            // 
            // listBoxQualityPlaylist
            // 
            this.listBoxQualityPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxQualityPlaylist.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxQualityPlaylist.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxQualityPlaylist.FormattingEnabled = true;
            this.listBoxQualityPlaylist.ItemHeight = 17;
            this.listBoxQualityPlaylist.Location = new System.Drawing.Point(-1, 23);
            this.listBoxQualityPlaylist.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxQualityPlaylist.Name = "listBoxQualityPlaylist";
            this.listBoxQualityPlaylist.Size = new System.Drawing.Size(217, 293);
            this.listBoxQualityPlaylist.TabIndex = 15;
            // 
            // buttonPlay
            // 
            this.buttonPlay.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlay.Location = new System.Drawing.Point(-1, -1);
            this.buttonPlay.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(109, 25);
            this.buttonPlay.TabIndex = 17;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // panelPlay
            // 
            this.panelPlay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlay.Controls.Add(this.buttonStop);
            this.panelPlay.Controls.Add(this.buttonPlay);
            this.panelPlay.Controls.Add(this.listBoxQualityPlaylist);
            this.panelPlay.Enabled = false;
            this.panelPlay.Location = new System.Drawing.Point(463, 39);
            this.panelPlay.Name = "panelPlay";
            this.panelPlay.Size = new System.Drawing.Size(217, 317);
            this.panelPlay.TabIndex = 18;
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStop.Location = new System.Drawing.Point(107, -1);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(109, 25);
            this.buttonStop.TabIndex = 18;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // panelFavorite
            // 
            this.panelFavorite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFavorite.Controls.Add(this.buttonAdd);
            this.panelFavorite.Controls.Add(this.buttonEdit);
            this.panelFavorite.Controls.Add(this.buttonRemove);
            this.panelFavorite.Controls.Add(this.listBoxFavorite);
            this.panelFavorite.Location = new System.Drawing.Point(12, 39);
            this.panelFavorite.Name = "panelFavorite";
            this.panelFavorite.Size = new System.Drawing.Size(217, 317);
            this.panelFavorite.TabIndex = 19;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(-1, 291);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(73, 25);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(71, 291);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(73, 25);
            this.buttonEdit.TabIndex = 20;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRemove.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.Location = new System.Drawing.Point(143, 291);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(73, 25);
            this.buttonRemove.TabIndex = 21;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // listBoxFavorite
            // 
            this.listBoxFavorite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFavorite.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxFavorite.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxFavorite.FormattingEnabled = true;
            this.listBoxFavorite.ItemHeight = 17;
            this.listBoxFavorite.Location = new System.Drawing.Point(-1, -1);
            this.listBoxFavorite.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxFavorite.Name = "listBoxFavorite";
            this.listBoxFavorite.Size = new System.Drawing.Size(217, 293);
            this.listBoxFavorite.TabIndex = 15;
            this.listBoxFavorite.SelectedIndexChanged += new System.EventHandler(this.listBoxFavorite_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionCheckToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(692, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // versionCheckToolStripMenuItem1
            // 
            this.versionCheckToolStripMenuItem1.Name = "versionCheckToolStripMenuItem1";
            this.versionCheckToolStripMenuItem1.Size = new System.Drawing.Size(92, 20);
            this.versionCheckToolStripMenuItem1.Text = "Version check";
            this.versionCheckToolStripMenuItem1.Click += new System.EventHandler(this.checkUpdateToolStripMenuItem1_Click);
            // 
            // StreamPlayer3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 368);
            this.Controls.Add(this.panelFavorite);
            this.Controls.Add(this.panelOpenStream);
            this.Controls.Add(this.panelPlay);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(708, 406);
            this.Name = "StreamPlayer3";
            this.Text = "StreamPlayer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBufferSize)).EndInit();
            this.panelBufferSize.ResumeLayout(false);
            this.panelBufferSize.PerformLayout();
            this.panelOpenStream.ResumeLayout(false);
            this.panelOpenStream.PerformLayout();
            this.panelPlay.ResumeLayout(false);
            this.panelFavorite.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenStream;
        private System.Windows.Forms.TextBox textBoxOpenStream;
        private System.Windows.Forms.TrackBar trackBarBufferSize;
        private System.Windows.Forms.Label labelBufferSize;
        private System.Windows.Forms.Panel panelBufferSize;
        private System.Windows.Forms.Panel panelOpenStream;
        private System.Windows.Forms.Label labelBufferSizeValue;
        private System.Windows.Forms.ListBox listBoxQualityPlaylist;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Panel panelPlay;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonCloseStream;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Panel panelFavorite;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxFavorite;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonChat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem versionCheckToolStripMenuItem1;
    }
}

