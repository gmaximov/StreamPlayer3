namespace StreamPlayer.App.Forms
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConfigReset = new System.Windows.Forms.Button();
            this.buttonConfigClose = new System.Windows.Forms.Button();
            this.buttonConfigSave = new System.Windows.Forms.Button();
            this.groupBoxPlayerSettings = new System.Windows.Forms.GroupBox();
            this.textBoxPlayerArgs = new System.Windows.Forms.TextBox();
            this.labelPlayerCommandLine = new System.Windows.Forms.Label();
            this.buttonPlayerPath = new System.Windows.Forms.Button();
            this.textBoxPlayerPath = new System.Windows.Forms.TextBox();
            this.labelPlayerPath = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxPlayerSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConfigReset
            // 
            this.buttonConfigReset.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfigReset.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.buttonConfigReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfigReset.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonConfigReset.Location = new System.Drawing.Point(158, 151);
            this.buttonConfigReset.Margin = new System.Windows.Forms.Padding(0);
            this.buttonConfigReset.MaximumSize = new System.Drawing.Size(73, 25);
            this.buttonConfigReset.MinimumSize = new System.Drawing.Size(73, 25);
            this.buttonConfigReset.Name = "buttonConfigReset";
            this.buttonConfigReset.Size = new System.Drawing.Size(73, 25);
            this.buttonConfigReset.TabIndex = 21;
            this.buttonConfigReset.Text = "Reset";
            this.buttonConfigReset.UseVisualStyleBackColor = true;
            this.buttonConfigReset.Click += new System.EventHandler(this.buttonConfigReset_Click);
            // 
            // buttonConfigClose
            // 
            this.buttonConfigClose.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConfigClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.buttonConfigClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfigClose.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonConfigClose.Location = new System.Drawing.Point(306, 151);
            this.buttonConfigClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonConfigClose.Name = "buttonConfigClose";
            this.buttonConfigClose.Size = new System.Drawing.Size(73, 25);
            this.buttonConfigClose.TabIndex = 20;
            this.buttonConfigClose.Text = "Close";
            this.buttonConfigClose.UseVisualStyleBackColor = true;
            this.buttonConfigClose.Click += new System.EventHandler(this.buttonConfigClose_Click);
            // 
            // buttonConfigSave
            // 
            this.buttonConfigSave.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonConfigSave.Enabled = false;
            this.buttonConfigSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.buttonConfigSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfigSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonConfigSave.Location = new System.Drawing.Point(9, 151);
            this.buttonConfigSave.Margin = new System.Windows.Forms.Padding(0);
            this.buttonConfigSave.Name = "buttonConfigSave";
            this.buttonConfigSave.Size = new System.Drawing.Size(73, 25);
            this.buttonConfigSave.TabIndex = 19;
            this.buttonConfigSave.Text = "Save";
            this.buttonConfigSave.UseVisualStyleBackColor = true;
            this.buttonConfigSave.Click += new System.EventHandler(this.buttonConfigSave_Click);
            // 
            // groupBoxPlayerSettings
            // 
            this.groupBoxPlayerSettings.Controls.Add(this.textBoxPlayerArgs);
            this.groupBoxPlayerSettings.Controls.Add(this.labelPlayerCommandLine);
            this.groupBoxPlayerSettings.Controls.Add(this.buttonPlayerPath);
            this.groupBoxPlayerSettings.Controls.Add(this.textBoxPlayerPath);
            this.groupBoxPlayerSettings.Controls.Add(this.labelPlayerPath);
            this.groupBoxPlayerSettings.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPlayerSettings.Name = "groupBoxPlayerSettings";
            this.groupBoxPlayerSettings.Size = new System.Drawing.Size(364, 118);
            this.groupBoxPlayerSettings.TabIndex = 0;
            this.groupBoxPlayerSettings.TabStop = false;
            this.groupBoxPlayerSettings.Text = "Player settings";
            // 
            // textBoxPlayerArgs
            // 
            this.textBoxPlayerArgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPlayerArgs.Location = new System.Drawing.Point(10, 84);
            this.textBoxPlayerArgs.Name = "textBoxPlayerArgs";
            this.textBoxPlayerArgs.Size = new System.Drawing.Size(288, 20);
            this.textBoxPlayerArgs.TabIndex = 21;
            this.textBoxPlayerArgs.Text = "-";
            this.textBoxPlayerArgs.TextChanged += new System.EventHandler(this.textBoxPlayerCommandLine_TextChanged);
            // 
            // labelPlayerCommandLine
            // 
            this.labelPlayerCommandLine.AutoSize = true;
            this.labelPlayerCommandLine.Location = new System.Drawing.Point(7, 67);
            this.labelPlayerCommandLine.Name = "labelPlayerCommandLine";
            this.labelPlayerCommandLine.Size = new System.Drawing.Size(242, 13);
            this.labelPlayerCommandLine.TabIndex = 20;
            this.labelPlayerCommandLine.Text = "Player command-line argument (for standart input):";
            // 
            // buttonPlayerPath
            // 
            this.buttonPlayerPath.FlatAppearance.BorderColor = System.Drawing.SystemColors.GrayText;
            this.buttonPlayerPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlayerPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonPlayerPath.Location = new System.Drawing.Point(301, 38);
            this.buttonPlayerPath.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPlayerPath.Name = "buttonPlayerPath";
            this.buttonPlayerPath.Size = new System.Drawing.Size(54, 20);
            this.buttonPlayerPath.TabIndex = 19;
            this.buttonPlayerPath.Text = "...";
            this.buttonPlayerPath.UseVisualStyleBackColor = true;
            this.buttonPlayerPath.Click += new System.EventHandler(this.buttonPlayerPath_Click);
            // 
            // textBoxPlayerPath
            // 
            this.textBoxPlayerPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPlayerPath.Location = new System.Drawing.Point(10, 38);
            this.textBoxPlayerPath.Name = "textBoxPlayerPath";
            this.textBoxPlayerPath.Size = new System.Drawing.Size(288, 20);
            this.textBoxPlayerPath.TabIndex = 1;
            this.textBoxPlayerPath.Text = "MPC-BE\\mpc-be.exe";
            this.textBoxPlayerPath.TextChanged += new System.EventHandler(this.textBoxPlayerPath_TextChanged);
            // 
            // labelPlayerPath
            // 
            this.labelPlayerPath.AutoSize = true;
            this.labelPlayerPath.Location = new System.Drawing.Point(7, 20);
            this.labelPlayerPath.Name = "labelPlayerPath";
            this.labelPlayerPath.Size = new System.Drawing.Size(63, 13);
            this.labelPlayerPath.TabIndex = 0;
            this.labelPlayerPath.Text = "Player path:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 185);
            this.ControlBox = false;
            this.Controls.Add(this.buttonConfigReset);
            this.Controls.Add(this.buttonConfigClose);
            this.Controls.Add(this.buttonConfigSave);
            this.Controls.Add(this.groupBoxPlayerSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormConfig_Load);
            this.groupBoxPlayerSettings.ResumeLayout(false);
            this.groupBoxPlayerSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonConfigClose;
        private System.Windows.Forms.Button buttonConfigSave;
        private System.Windows.Forms.GroupBox groupBoxPlayerSettings;
        private System.Windows.Forms.TextBox textBoxPlayerArgs;
        private System.Windows.Forms.Label labelPlayerCommandLine;
        private System.Windows.Forms.Button buttonPlayerPath;
        private System.Windows.Forms.TextBox textBoxPlayerPath;
        private System.Windows.Forms.Label labelPlayerPath;
        private System.Windows.Forms.Button buttonConfigReset;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}