namespace Wall_e_Controller
{
    partial class SettingsForm
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
            this.ArduinoComTitleLabel = new System.Windows.Forms.Label();
            this.ComBox = new System.Windows.Forms.ComboBox();
            this.RPiIPTitleLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.IPDot1 = new System.Windows.Forms.Label();
            this.IPDot3 = new System.Windows.Forms.Label();
            this.IPDot2 = new System.Windows.Forms.Label();
            this.RPiIPOne = new System.Windows.Forms.NumericUpDown();
            this.RPiIPFour = new System.Windows.Forms.NumericUpDown();
            this.RPiIPThree = new System.Windows.Forms.NumericUpDown();
            this.RPiIPTwo = new System.Windows.Forms.NumericUpDown();
            this.CommunicationSettingsLabel = new System.Windows.Forms.Label();
            this.MotorSettingsLabel = new System.Windows.Forms.Label();
            this.LeftMotorOffsetLabel = new System.Windows.Forms.Label();
            this.LeftMotorOffset = new System.Windows.Forms.NumericUpDown();
            this.RightMotorOffset = new System.Windows.Forms.NumericUpDown();
            this.RightMotorOffsetLabel = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.SteeringSettingsLabel = new System.Windows.Forms.Label();
            this.InverseSteering = new System.Windows.Forms.CheckBox();
            this.InverseSteeringLabel = new System.Windows.Forms.Label();
            this.MotorPower = new System.Windows.Forms.NumericUpDown();
            this.MotorPowerLabel = new System.Windows.Forms.Label();
            this.AxisTurnPower = new System.Windows.Forms.NumericUpDown();
            this.AxisTurnPowerLabel = new System.Windows.Forms.Label();
            this.TurnPower = new System.Windows.Forms.NumericUpDown();
            this.TurnPowerLabel = new System.Windows.Forms.Label();
            this.PowerIncreaseLabel = new System.Windows.Forms.Label();
            this.PowerIncrease = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.RPiIPOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPiIPFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPiIPThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPiIPTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMotorOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightMotorOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotorPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AxisTurnPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerIncrease)).BeginInit();
            this.SuspendLayout();
            // 
            // ArduinoComTitleLabel
            // 
            this.ArduinoComTitleLabel.AutoSize = true;
            this.ArduinoComTitleLabel.Location = new System.Drawing.Point(12, 33);
            this.ArduinoComTitleLabel.Name = "ArduinoComTitleLabel";
            this.ArduinoComTitleLabel.Size = new System.Drawing.Size(130, 17);
            this.ArduinoComTitleLabel.TabIndex = 0;
            this.ArduinoComTitleLabel.Text = "Send Module COM:";
            // 
            // ComBox
            // 
            this.ComBox.FormattingEnabled = true;
            this.ComBox.Location = new System.Drawing.Point(227, 30);
            this.ComBox.Name = "ComBox";
            this.ComBox.Size = new System.Drawing.Size(214, 24);
            this.ComBox.TabIndex = 1;
            // 
            // RPiIPTitleLabel
            // 
            this.RPiIPTitleLabel.AutoSize = true;
            this.RPiIPTitleLabel.Location = new System.Drawing.Point(12, 62);
            this.RPiIPTitleLabel.Name = "RPiIPTitleLabel";
            this.RPiIPTitleLabel.Size = new System.Drawing.Size(117, 17);
            this.RPiIPTitleLabel.TabIndex = 2;
            this.RPiIPTitleLabel.Text = "Wall-E IP Adress:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "hjgfhjkhgjkuhgfvbjkljhgfdcvbnmjkhgfdcvbghjkljhgfghjkljhg";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 0;
            // 
            // IPDot1
            // 
            this.IPDot1.AutoSize = true;
            this.IPDot1.Location = new System.Drawing.Point(273, 66);
            this.IPDot1.Name = "IPDot1";
            this.IPDot1.Size = new System.Drawing.Size(12, 17);
            this.IPDot1.TabIndex = 7;
            this.IPDot1.Text = ".";
            // 
            // IPDot3
            // 
            this.IPDot3.AutoSize = true;
            this.IPDot3.Location = new System.Drawing.Point(385, 67);
            this.IPDot3.Name = "IPDot3";
            this.IPDot3.Size = new System.Drawing.Size(12, 17);
            this.IPDot3.TabIndex = 8;
            this.IPDot3.Text = ".";
            // 
            // IPDot2
            // 
            this.IPDot2.AutoSize = true;
            this.IPDot2.Location = new System.Drawing.Point(329, 67);
            this.IPDot2.Name = "IPDot2";
            this.IPDot2.Size = new System.Drawing.Size(12, 17);
            this.IPDot2.TabIndex = 10;
            this.IPDot2.Text = ".";
            // 
            // RPiIPOne
            // 
            this.RPiIPOne.Location = new System.Drawing.Point(227, 62);
            this.RPiIPOne.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.RPiIPOne.Name = "RPiIPOne";
            this.RPiIPOne.Size = new System.Drawing.Size(48, 22);
            this.RPiIPOne.TabIndex = 11;
            // 
            // RPiIPFour
            // 
            this.RPiIPFour.Location = new System.Drawing.Point(393, 62);
            this.RPiIPFour.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.RPiIPFour.Name = "RPiIPFour";
            this.RPiIPFour.Size = new System.Drawing.Size(48, 22);
            this.RPiIPFour.TabIndex = 14;
            // 
            // RPiIPThree
            // 
            this.RPiIPThree.Location = new System.Drawing.Point(338, 62);
            this.RPiIPThree.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.RPiIPThree.Name = "RPiIPThree";
            this.RPiIPThree.Size = new System.Drawing.Size(48, 22);
            this.RPiIPThree.TabIndex = 13;
            // 
            // RPiIPTwo
            // 
            this.RPiIPTwo.Location = new System.Drawing.Point(282, 62);
            this.RPiIPTwo.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.RPiIPTwo.Name = "RPiIPTwo";
            this.RPiIPTwo.Size = new System.Drawing.Size(48, 22);
            this.RPiIPTwo.TabIndex = 12;
            // 
            // CommunicationSettingsLabel
            // 
            this.CommunicationSettingsLabel.AutoSize = true;
            this.CommunicationSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommunicationSettingsLabel.Location = new System.Drawing.Point(12, 9);
            this.CommunicationSettingsLabel.Name = "CommunicationSettingsLabel";
            this.CommunicationSettingsLabel.Size = new System.Drawing.Size(181, 17);
            this.CommunicationSettingsLabel.TabIndex = 15;
            this.CommunicationSettingsLabel.Text = "Communication Settings";
            // 
            // MotorSettingsLabel
            // 
            this.MotorSettingsLabel.AutoSize = true;
            this.MotorSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotorSettingsLabel.Location = new System.Drawing.Point(12, 98);
            this.MotorSettingsLabel.Name = "MotorSettingsLabel";
            this.MotorSettingsLabel.Size = new System.Drawing.Size(113, 17);
            this.MotorSettingsLabel.TabIndex = 16;
            this.MotorSettingsLabel.Text = "Motor Settings";
            // 
            // LeftMotorOffsetLabel
            // 
            this.LeftMotorOffsetLabel.AutoSize = true;
            this.LeftMotorOffsetLabel.Location = new System.Drawing.Point(12, 120);
            this.LeftMotorOffsetLabel.Name = "LeftMotorOffsetLabel";
            this.LeftMotorOffsetLabel.Size = new System.Drawing.Size(118, 17);
            this.LeftMotorOffsetLabel.TabIndex = 17;
            this.LeftMotorOffsetLabel.Text = "Left Motor Offset:";
            // 
            // LeftMotorOffset
            // 
            this.LeftMotorOffset.Location = new System.Drawing.Point(227, 120);
            this.LeftMotorOffset.Name = "LeftMotorOffset";
            this.LeftMotorOffset.Size = new System.Drawing.Size(214, 22);
            this.LeftMotorOffset.TabIndex = 18;
            // 
            // RightMotorOffset
            // 
            this.RightMotorOffset.Location = new System.Drawing.Point(227, 149);
            this.RightMotorOffset.Name = "RightMotorOffset";
            this.RightMotorOffset.Size = new System.Drawing.Size(214, 22);
            this.RightMotorOffset.TabIndex = 20;
            // 
            // RightMotorOffsetLabel
            // 
            this.RightMotorOffsetLabel.AutoSize = true;
            this.RightMotorOffsetLabel.Location = new System.Drawing.Point(12, 149);
            this.RightMotorOffsetLabel.Name = "RightMotorOffsetLabel";
            this.RightMotorOffsetLabel.Size = new System.Drawing.Size(127, 17);
            this.RightMotorOffsetLabel.TabIndex = 19;
            this.RightMotorOffsetLabel.Text = "Right Motor Offset:";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(151, 361);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(151, 37);
            this.ApplyButton.TabIndex = 21;
            this.ApplyButton.Text = "Apply Changes";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // SteeringSettingsLabel
            // 
            this.SteeringSettingsLabel.AutoSize = true;
            this.SteeringSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SteeringSettingsLabel.Location = new System.Drawing.Point(12, 241);
            this.SteeringSettingsLabel.Name = "SteeringSettingsLabel";
            this.SteeringSettingsLabel.Size = new System.Drawing.Size(133, 17);
            this.SteeringSettingsLabel.TabIndex = 22;
            this.SteeringSettingsLabel.Text = "Steering Settings";
            // 
            // InverseSteering
            // 
            this.InverseSteering.AutoSize = true;
            this.InverseSteering.Location = new System.Drawing.Point(423, 263);
            this.InverseSteering.Name = "InverseSteering";
            this.InverseSteering.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InverseSteering.Size = new System.Drawing.Size(18, 17);
            this.InverseSteering.TabIndex = 23;
            this.InverseSteering.UseVisualStyleBackColor = true;
            // 
            // InverseSteeringLabel
            // 
            this.InverseSteeringLabel.AutoSize = true;
            this.InverseSteeringLabel.Location = new System.Drawing.Point(12, 263);
            this.InverseSteeringLabel.Name = "InverseSteeringLabel";
            this.InverseSteeringLabel.Size = new System.Drawing.Size(115, 17);
            this.InverseSteeringLabel.TabIndex = 24;
            this.InverseSteeringLabel.Text = "Inverse Steering:";
            // 
            // MotorPower
            // 
            this.MotorPower.Location = new System.Drawing.Point(227, 177);
            this.MotorPower.Name = "MotorPower";
            this.MotorPower.Size = new System.Drawing.Size(214, 22);
            this.MotorPower.TabIndex = 26;
            // 
            // MotorPowerLabel
            // 
            this.MotorPowerLabel.AutoSize = true;
            this.MotorPowerLabel.Location = new System.Drawing.Point(12, 177);
            this.MotorPowerLabel.Name = "MotorPowerLabel";
            this.MotorPowerLabel.Size = new System.Drawing.Size(142, 17);
            this.MotorPowerLabel.TabIndex = 25;
            this.MotorPowerLabel.Text = "Minimal Motor Power:";
            // 
            // AxisTurnPower
            // 
            this.AxisTurnPower.Location = new System.Drawing.Point(227, 291);
            this.AxisTurnPower.Name = "AxisTurnPower";
            this.AxisTurnPower.Size = new System.Drawing.Size(214, 22);
            this.AxisTurnPower.TabIndex = 28;
            // 
            // AxisTurnPowerLabel
            // 
            this.AxisTurnPowerLabel.AutoSize = true;
            this.AxisTurnPowerLabel.Location = new System.Drawing.Point(12, 291);
            this.AxisTurnPowerLabel.Name = "AxisTurnPowerLabel";
            this.AxisTurnPowerLabel.Size = new System.Drawing.Size(165, 17);
            this.AxisTurnPowerLabel.TabIndex = 27;
            this.AxisTurnPowerLabel.Text = "Minimal Axis Turn Power:";
            // 
            // TurnPower
            // 
            this.TurnPower.Location = new System.Drawing.Point(227, 319);
            this.TurnPower.Name = "TurnPower";
            this.TurnPower.Size = new System.Drawing.Size(214, 22);
            this.TurnPower.TabIndex = 30;
            // 
            // TurnPowerLabel
            // 
            this.TurnPowerLabel.AutoSize = true;
            this.TurnPowerLabel.Location = new System.Drawing.Point(12, 319);
            this.TurnPowerLabel.Name = "TurnPowerLabel";
            this.TurnPowerLabel.Size = new System.Drawing.Size(136, 17);
            this.TurnPowerLabel.TabIndex = 29;
            this.TurnPowerLabel.Text = "Minimal Turn Power:";
            // 
            // PowerIncreaseLabel
            // 
            this.PowerIncreaseLabel.AutoSize = true;
            this.PowerIncreaseLabel.Location = new System.Drawing.Point(12, 205);
            this.PowerIncreaseLabel.Name = "PowerIncreaseLabel";
            this.PowerIncreaseLabel.Size = new System.Drawing.Size(154, 17);
            this.PowerIncreaseLabel.TabIndex = 31;
            this.PowerIncreaseLabel.Text = "Power Increase Speed:";
            // 
            // PowerIncrease
            // 
            this.PowerIncrease.Location = new System.Drawing.Point(227, 207);
            this.PowerIncrease.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PowerIncrease.Name = "PowerIncrease";
            this.PowerIncrease.Size = new System.Drawing.Size(214, 22);
            this.PowerIncrease.TabIndex = 32;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 410);
            this.Controls.Add(this.PowerIncrease);
            this.Controls.Add(this.PowerIncreaseLabel);
            this.Controls.Add(this.TurnPower);
            this.Controls.Add(this.TurnPowerLabel);
            this.Controls.Add(this.AxisTurnPower);
            this.Controls.Add(this.AxisTurnPowerLabel);
            this.Controls.Add(this.MotorPower);
            this.Controls.Add(this.MotorPowerLabel);
            this.Controls.Add(this.InverseSteeringLabel);
            this.Controls.Add(this.InverseSteering);
            this.Controls.Add(this.SteeringSettingsLabel);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.RightMotorOffset);
            this.Controls.Add(this.RightMotorOffsetLabel);
            this.Controls.Add(this.LeftMotorOffset);
            this.Controls.Add(this.LeftMotorOffsetLabel);
            this.Controls.Add(this.MotorSettingsLabel);
            this.Controls.Add(this.CommunicationSettingsLabel);
            this.Controls.Add(this.RPiIPTwo);
            this.Controls.Add(this.RPiIPThree);
            this.Controls.Add(this.RPiIPFour);
            this.Controls.Add(this.RPiIPOne);
            this.Controls.Add(this.RPiIPTitleLabel);
            this.Controls.Add(this.ComBox);
            this.Controls.Add(this.ArduinoComTitleLabel);
            this.Controls.Add(this.IPDot1);
            this.Controls.Add(this.IPDot2);
            this.Controls.Add(this.IPDot3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Wall-E Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.settingsForm_FormClosing);
            this.Load += new System.EventHandler(this.settingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RPiIPOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPiIPFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPiIPThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RPiIPTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftMotorOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightMotorOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotorPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AxisTurnPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PowerIncrease)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArduinoComTitleLabel;
        private System.Windows.Forms.ComboBox ComBox;
        private System.Windows.Forms.Label RPiIPTitleLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label IPDot1;
        private System.Windows.Forms.Label IPDot3;
        private System.Windows.Forms.Label IPDot2;
        private System.Windows.Forms.NumericUpDown RPiIPOne;
        private System.Windows.Forms.NumericUpDown RPiIPFour;
        private System.Windows.Forms.NumericUpDown RPiIPThree;
        private System.Windows.Forms.NumericUpDown RPiIPTwo;
        private System.Windows.Forms.Label CommunicationSettingsLabel;
        private System.Windows.Forms.Label MotorSettingsLabel;
        private System.Windows.Forms.Label LeftMotorOffsetLabel;
        private System.Windows.Forms.NumericUpDown LeftMotorOffset;
        private System.Windows.Forms.NumericUpDown RightMotorOffset;
        private System.Windows.Forms.Label RightMotorOffsetLabel;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label SteeringSettingsLabel;
        private System.Windows.Forms.CheckBox InverseSteering;
        private System.Windows.Forms.Label InverseSteeringLabel;
        private System.Windows.Forms.NumericUpDown MotorPower;
        private System.Windows.Forms.Label MotorPowerLabel;
        private System.Windows.Forms.NumericUpDown AxisTurnPower;
        private System.Windows.Forms.Label AxisTurnPowerLabel;
        private System.Windows.Forms.NumericUpDown TurnPower;
        private System.Windows.Forms.Label TurnPowerLabel;
        private System.Windows.Forms.Label PowerIncreaseLabel;
        private System.Windows.Forms.NumericUpDown PowerIncrease;
    }
}