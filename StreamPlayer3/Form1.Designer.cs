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
            this.panelTimeoutSettings = new System.Windows.Forms.Panel();
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
            this.numericUpDownTimeout = new System.Windows.Forms.NumericUpDown();
            this.checkBoxTimeout = new System.Windows.Forms.CheckBox();
            this.labelTimeout = new System.Windows.Forms.Label();
            this.panelPlayerSettings = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBufferSize)).BeginInit();
            this.panelBufferSize.SuspendLayout();
            this.panelOpenStream.SuspendLayout();
            this.panelTimeoutSettings.SuspendLayout();
            this.panelPlay.SuspendLayout();
            this.panelFavorite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeout)).BeginInit();
            this.panelPlayerSettings.SuspendLayout();
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
            this.buttonOpenStream.Text = "Open Stream";
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
            this.textBoxOpenStream.Text = "Nightblue3";
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
            this.panelBufferSize.Location = new System.Drawing.Point(-1, 204);
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
            this.panelOpenStream.Controls.Add(this.panelBufferSize);
            this.panelOpenStream.Controls.Add(this.panelPlayerSettings);
            this.panelOpenStream.Controls.Add(this.panelTimeoutSettings);
            this.panelOpenStream.Controls.Add(this.labelState);
            this.panelOpenStream.Controls.Add(this.buttonCloseStream);
            this.panelOpenStream.Controls.Add(this.buttonOpenStream);
            this.panelOpenStream.Controls.Add(this.textBoxOpenStream);
            this.panelOpenStream.Location = new System.Drawing.Point(235, 12);
            this.panelOpenStream.Name = "panelOpenStream";
            this.panelOpenStream.Size = new System.Drawing.Size(217, 317);
            this.panelOpenStream.TabIndex = 12;
            // 
            // panelTimeoutSettings
            // 
            this.panelTimeoutSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTimeoutSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTimeoutSettings.Controls.Add(this.labelTimeout);
            this.panelTimeoutSettings.Controls.Add(this.checkBoxTimeout);
            this.panelTimeoutSettings.Controls.Add(this.numericUpDownTimeout);
            this.panelTimeoutSettings.Location = new System.Drawing.Point(-1, 148);
            this.panelTimeoutSettings.Name = "panelTimeoutSettings";
            this.panelTimeoutSettings.Size = new System.Drawing.Size(217, 57);
            this.panelTimeoutSettings.TabIndex = 21;
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
            this.buttonCloseStream.Text = "Close Stream";
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
            this.panelPlay.Location = new System.Drawing.Point(458, 12);
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
            this.panelFavorite.Location = new System.Drawing.Point(12, 12);
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
            // numericUpDownTimeout
            // 
            this.numericUpDownTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownTimeout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownTimeout.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTimeout.Location = new System.Drawing.Point(6, 24);
            this.numericUpDownTimeout.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericUpDownTimeout.Name = "numericUpDownTimeout";
            this.numericUpDownTimeout.Size = new System.Drawing.Size(102, 25);
            this.numericUpDownTimeout.TabIndex = 0;
            this.numericUpDownTimeout.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // checkBoxTimeout
            // 
            this.checkBoxTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxTimeout.AutoSize = true;
            this.checkBoxTimeout.Location = new System.Drawing.Point(125, 28);
            this.checkBoxTimeout.Name = "checkBoxTimeout";
            this.checkBoxTimeout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxTimeout.Size = new System.Drawing.Size(77, 17);
            this.checkBoxTimeout.TabIndex = 1;
            this.checkBoxTimeout.Text = "No timeout";
            this.checkBoxTimeout.UseVisualStyleBackColor = true;
            this.checkBoxTimeout.CheckedChanged += new System.EventHandler(this.checkBoxTimeout_CheckedChanged);
            // 
            // labelTimeout
            // 
            this.labelTimeout.AutoSize = true;
            this.labelTimeout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeout.Location = new System.Drawing.Point(3, 4);
            this.labelTimeout.Margin = new System.Windows.Forms.Padding(0);
            this.labelTimeout.Name = "labelTimeout";
            this.labelTimeout.Size = new System.Drawing.Size(55, 17);
            this.labelTimeout.TabIndex = 9;
            this.labelTimeout.Text = "Timeout";
            // 
            // panelPlayerSettings
            // 
            this.panelPlayerSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPlayerSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlayerSettings.Controls.Add(this.label1);
            this.panelPlayerSettings.Controls.Add(this.checkBox1);
            this.panelPlayerSettings.Location = new System.Drawing.Point(-1, 259);
            this.panelPlayerSettings.Name = "panelPlayerSettings";
            this.panelPlayerSettings.Size = new System.Drawing.Size(217, 57);
            this.panelPlayerSettings.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Player settings";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox1.Size = new System.Drawing.Size(203, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Try to open player again, if it is closed";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // StreamPlayer3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 349);
            this.Controls.Add(this.panelFavorite);
            this.Controls.Add(this.panelOpenStream);
            this.Controls.Add(this.panelPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StreamPlayer3";
            this.Text = "StreamPlayer3 v0.7";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBufferSize)).EndInit();
            this.panelBufferSize.ResumeLayout(false);
            this.panelBufferSize.PerformLayout();
            this.panelOpenStream.ResumeLayout(false);
            this.panelOpenStream.PerformLayout();
            this.panelTimeoutSettings.ResumeLayout(false);
            this.panelTimeoutSettings.PerformLayout();
            this.panelPlay.ResumeLayout(false);
            this.panelFavorite.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTimeout)).EndInit();
            this.panelPlayerSettings.ResumeLayout(false);
            this.panelPlayerSettings.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panelTimeoutSettings;
        private System.Windows.Forms.Label labelTimeout;
        private System.Windows.Forms.CheckBox checkBoxTimeout;
        private System.Windows.Forms.NumericUpDown numericUpDownTimeout;
        private System.Windows.Forms.Panel panelPlayerSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

