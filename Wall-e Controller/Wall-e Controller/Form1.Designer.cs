namespace Wall_e_Controller
{
    partial class Form1
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
            if (disposing && (components != null))
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
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ArduinoComTitleLabel = new System.Windows.Forms.Label();
            this.RPiIPTitleLabel = new System.Windows.Forms.Label();
            this.ArduinoStatusTitleLabel = new System.Windows.Forms.Label();
            this.RPiStatusTitleLabel = new System.Windows.Forms.Label();
            this.RPiStatusLabel = new System.Windows.Forms.Label();
            this.ArduinoStatusLabel = new System.Windows.Forms.Label();
            this.RPiIPLabel = new System.Windows.Forms.Label();
            this.ArduinoComLabel = new System.Windows.Forms.Label();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.CamView = new System.Windows.Forms.PictureBox();
            this.AtButton = new System.Windows.Forms.Button();
            this.PowerBackground = new System.Windows.Forms.Panel();
            this.PowerLabel = new System.Windows.Forms.Label();
            this.IncomingDataTextBox = new System.Windows.Forms.TextBox();
            this.EqualTextboxSizeContainer = new System.Windows.Forms.SplitContainer();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.HorizontalDivider = new System.Windows.Forms.Label();
            this.VerticalDivider = new System.Windows.Forms.Label();
            this.LabelDivider = new System.Windows.Forms.Label();
            this.IncomingDataTextBoxTitle = new System.Windows.Forms.Label();
            this.LogTextBoxTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CamView)).BeginInit();
            this.PowerBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EqualTextboxSizeContainer)).BeginInit();
            this.EqualTextboxSizeContainer.Panel1.SuspendLayout();
            this.EqualTextboxSizeContainer.Panel2.SuspendLayout();
            this.EqualTextboxSizeContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsButton.Location = new System.Drawing.Point(956, 9);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(94, 40);
            this.SettingsButton.TabIndex = 0;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // ArduinoComTitleLabel
            // 
            this.ArduinoComTitleLabel.AutoSize = true;
            this.ArduinoComTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.ArduinoComTitleLabel.Name = "ArduinoComTitleLabel";
            this.ArduinoComTitleLabel.Size = new System.Drawing.Size(96, 17);
            this.ArduinoComTitleLabel.TabIndex = 2;
            this.ArduinoComTitleLabel.Text = "Arduino COM:";
            // 
            // RPiIPTitleLabel
            // 
            this.RPiIPTitleLabel.AutoSize = true;
            this.RPiIPTitleLabel.Location = new System.Drawing.Point(12, 26);
            this.RPiIPTitleLabel.Name = "RPiIPTitleLabel";
            this.RPiIPTitleLabel.Size = new System.Drawing.Size(106, 17);
            this.RPiIPTitleLabel.TabIndex = 3;
            this.RPiIPTitleLabel.Text = "RPi IP Address:";
            // 
            // ArduinoStatusTitleLabel
            // 
            this.ArduinoStatusTitleLabel.AutoSize = true;
            this.ArduinoStatusTitleLabel.Location = new System.Drawing.Point(272, 9);
            this.ArduinoStatusTitleLabel.Name = "ArduinoStatusTitleLabel";
            this.ArduinoStatusTitleLabel.Size = new System.Drawing.Size(103, 17);
            this.ArduinoStatusTitleLabel.TabIndex = 4;
            this.ArduinoStatusTitleLabel.Text = "Arduino status:";
            // 
            // RPiStatusTitleLabel
            // 
            this.RPiStatusTitleLabel.AutoSize = true;
            this.RPiStatusTitleLabel.Location = new System.Drawing.Point(272, 26);
            this.RPiStatusTitleLabel.Name = "RPiStatusTitleLabel";
            this.RPiStatusTitleLabel.Size = new System.Drawing.Size(78, 17);
            this.RPiStatusTitleLabel.TabIndex = 5;
            this.RPiStatusTitleLabel.Text = "RPi Status:";
            // 
            // RPiStatusLabel
            // 
            this.RPiStatusLabel.AutoSize = true;
            this.RPiStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.RPiStatusLabel.Location = new System.Drawing.Point(384, 26);
            this.RPiStatusLabel.Name = "RPiStatusLabel";
            this.RPiStatusLabel.Size = new System.Drawing.Size(56, 17);
            this.RPiStatusLabel.TabIndex = 9;
            this.RPiStatusLabel.Text = "inactive";
            // 
            // ArduinoStatusLabel
            // 
            this.ArduinoStatusLabel.AutoSize = true;
            this.ArduinoStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.ArduinoStatusLabel.Location = new System.Drawing.Point(384, 9);
            this.ArduinoStatusLabel.Name = "ArduinoStatusLabel";
            this.ArduinoStatusLabel.Size = new System.Drawing.Size(56, 17);
            this.ArduinoStatusLabel.TabIndex = 8;
            this.ArduinoStatusLabel.Text = "inactive";
            // 
            // RPiIPLabel
            // 
            this.RPiIPLabel.AutoSize = true;
            this.RPiIPLabel.Location = new System.Drawing.Point(124, 26);
            this.RPiIPLabel.Name = "RPiIPLabel";
            this.RPiIPLabel.Size = new System.Drawing.Size(84, 17);
            this.RPiIPLabel.TabIndex = 7;
            this.RPiIPLabel.Text = "192.168.1.2";
            // 
            // ArduinoComLabel
            // 
            this.ArduinoComLabel.AutoSize = true;
            this.ArduinoComLabel.Location = new System.Drawing.Point(124, 9);
            this.ArduinoComLabel.Name = "ArduinoComLabel";
            this.ArduinoComLabel.Size = new System.Drawing.Size(47, 17);
            this.ArduinoComLabel.TabIndex = 6;
            this.ArduinoComLabel.Text = "COM0";
            // 
            // ConnectButton
            // 
            this.ConnectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectButton.Location = new System.Drawing.Point(756, 9);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(94, 40);
            this.ConnectButton.TabIndex = 10;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // CamView
            // 
            this.CamView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CamView.Location = new System.Drawing.Point(12, 57);
            this.CamView.Name = "CamView";
            this.CamView.Size = new System.Drawing.Size(730, 503);
            this.CamView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CamView.TabIndex = 11;
            this.CamView.TabStop = false;
            // 
            // AtButton
            // 
            this.AtButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AtButton.Location = new System.Drawing.Point(856, 9);
            this.AtButton.Name = "AtButton";
            this.AtButton.Size = new System.Drawing.Size(94, 40);
            this.AtButton.TabIndex = 12;
            this.AtButton.Text = "AT-Console";
            this.AtButton.UseVisualStyleBackColor = true;
            // 
            // PowerBackground
            // 
            this.PowerBackground.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PowerBackground.BackColor = System.Drawing.Color.Black;
            this.PowerBackground.Controls.Add(this.PowerLabel);
            this.PowerBackground.Location = new System.Drawing.Point(756, 517);
            this.PowerBackground.Name = "PowerBackground";
            this.PowerBackground.Size = new System.Drawing.Size(294, 43);
            this.PowerBackground.TabIndex = 13;
            // 
            // PowerLabel
            // 
            this.PowerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PowerLabel.AutoSize = true;
            this.PowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerLabel.ForeColor = System.Drawing.Color.White;
            this.PowerLabel.Location = new System.Drawing.Point(3, 3);
            this.PowerLabel.Name = "PowerLabel";
            this.PowerLabel.Size = new System.Drawing.Size(146, 38);
            this.PowerLabel.TabIndex = 0;
            this.PowerLabel.Text = "Power: 0";
            // 
            // IncomingDataTextBox
            // 
            this.IncomingDataTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IncomingDataTextBox.Location = new System.Drawing.Point(0, 20);
            this.IncomingDataTextBox.Multiline = true;
            this.IncomingDataTextBox.Name = "IncomingDataTextBox";
            this.IncomingDataTextBox.ReadOnly = true;
            this.IncomingDataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.IncomingDataTextBox.Size = new System.Drawing.Size(294, 203);
            this.IncomingDataTextBox.TabIndex = 14;
            // 
            // EqualTextboxSizeContainer
            // 
            this.EqualTextboxSizeContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EqualTextboxSizeContainer.IsSplitterFixed = true;
            this.EqualTextboxSizeContainer.Location = new System.Drawing.Point(756, 57);
            this.EqualTextboxSizeContainer.Name = "EqualTextboxSizeContainer";
            this.EqualTextboxSizeContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // EqualTextboxSizeContainer.Panel1
            // 
            this.EqualTextboxSizeContainer.Panel1.Controls.Add(this.IncomingDataTextBoxTitle);
            this.EqualTextboxSizeContainer.Panel1.Controls.Add(this.IncomingDataTextBox);
            // 
            // EqualTextboxSizeContainer.Panel2
            // 
            this.EqualTextboxSizeContainer.Panel2.Controls.Add(this.LogTextBoxTitle);
            this.EqualTextboxSizeContainer.Panel2.Controls.Add(this.LogTextBox);
            this.EqualTextboxSizeContainer.Size = new System.Drawing.Size(294, 454);
            this.EqualTextboxSizeContainer.SplitterDistance = 225;
            this.EqualTextboxSizeContainer.TabIndex = 15;
            // 
            // LogTextBox
            // 
            this.LogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogTextBox.Location = new System.Drawing.Point(0, 20);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(294, 203);
            this.LogTextBox.TabIndex = 15;
            // 
            // HorizontalDivider
            // 
            this.HorizontalDivider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HorizontalDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.HorizontalDivider.Location = new System.Drawing.Point(0, 52);
            this.HorizontalDivider.Name = "HorizontalDivider";
            this.HorizontalDivider.Size = new System.Drawing.Size(1063, 2);
            this.HorizontalDivider.TabIndex = 17;
            // 
            // VerticalDivider
            // 
            this.VerticalDivider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VerticalDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VerticalDivider.Location = new System.Drawing.Point(748, 53);
            this.VerticalDivider.Name = "VerticalDivider";
            this.VerticalDivider.Size = new System.Drawing.Size(2, 517);
            this.VerticalDivider.TabIndex = 18;
            // 
            // LabelDivider
            // 
            this.LabelDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelDivider.Location = new System.Drawing.Point(255, 8);
            this.LabelDivider.Name = "LabelDivider";
            this.LabelDivider.Size = new System.Drawing.Size(2, 41);
            this.LabelDivider.TabIndex = 19;
            // 
            // IncomingDataTextBoxTitle
            // 
            this.IncomingDataTextBoxTitle.AutoSize = true;
            this.IncomingDataTextBoxTitle.Location = new System.Drawing.Point(0, 0);
            this.IncomingDataTextBoxTitle.Name = "IncomingDataTextBoxTitle";
            this.IncomingDataTextBoxTitle.Size = new System.Drawing.Size(102, 17);
            this.IncomingDataTextBoxTitle.TabIndex = 20;
            this.IncomingDataTextBoxTitle.Text = "Incoming Data:";
            // 
            // LogTextBoxTitle
            // 
            this.LogTextBoxTitle.AutoSize = true;
            this.LogTextBoxTitle.Location = new System.Drawing.Point(0, 0);
            this.LogTextBoxTitle.Name = "LogTextBoxTitle";
            this.LogTextBoxTitle.Size = new System.Drawing.Size(101, 17);
            this.LogTextBoxTitle.TabIndex = 21;
            this.LogTextBoxTitle.Text = "Controller Log:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 573);
            this.Controls.Add(this.LabelDivider);
            this.Controls.Add(this.VerticalDivider);
            this.Controls.Add(this.HorizontalDivider);
            this.Controls.Add(this.EqualTextboxSizeContainer);
            this.Controls.Add(this.PowerBackground);
            this.Controls.Add(this.AtButton);
            this.Controls.Add(this.CamView);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.RPiStatusLabel);
            this.Controls.Add(this.ArduinoStatusLabel);
            this.Controls.Add(this.RPiIPLabel);
            this.Controls.Add(this.ArduinoComLabel);
            this.Controls.Add(this.RPiStatusTitleLabel);
            this.Controls.Add(this.ArduinoStatusTitleLabel);
            this.Controls.Add(this.RPiIPTitleLabel);
            this.Controls.Add(this.ArduinoComTitleLabel);
            this.Controls.Add(this.SettingsButton);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(780, 390);
            this.Name = "Form1";
            this.Text = "Wall-e Controller";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseWheel);
            ((System.ComponentModel.ISupportInitialize)(this.CamView)).EndInit();
            this.PowerBackground.ResumeLayout(false);
            this.PowerBackground.PerformLayout();
            this.EqualTextboxSizeContainer.Panel1.ResumeLayout(false);
            this.EqualTextboxSizeContainer.Panel1.PerformLayout();
            this.EqualTextboxSizeContainer.Panel2.ResumeLayout(false);
            this.EqualTextboxSizeContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EqualTextboxSizeContainer)).EndInit();
            this.EqualTextboxSizeContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Label ArduinoComTitleLabel;
        private System.Windows.Forms.Label RPiIPTitleLabel;
        private System.Windows.Forms.Label ArduinoStatusTitleLabel;
        private System.Windows.Forms.Label RPiStatusTitleLabel;
        private System.Windows.Forms.Label RPiStatusLabel;
        private System.Windows.Forms.Label ArduinoStatusLabel;
        private System.Windows.Forms.Label RPiIPLabel;
        private System.Windows.Forms.Label ArduinoComLabel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.PictureBox CamView;
        private System.Windows.Forms.Button AtButton;
        private System.Windows.Forms.Panel PowerBackground;
        private System.Windows.Forms.Label PowerLabel;
        private System.Windows.Forms.TextBox IncomingDataTextBox;
        private System.Windows.Forms.SplitContainer EqualTextboxSizeContainer;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Label HorizontalDivider;
        private System.Windows.Forms.Label VerticalDivider;
        private System.Windows.Forms.Label LabelDivider;
        private System.Windows.Forms.Label IncomingDataTextBoxTitle;
        private System.Windows.Forms.Label LogTextBoxTitle;
    }
}

