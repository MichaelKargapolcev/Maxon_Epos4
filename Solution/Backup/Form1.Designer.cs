namespace Demo_EposCmd
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxAOM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNodeId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTargetPosition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonRelativeMode = new System.Windows.Forms.RadioButton();
            this.radioButtonAbsoluteMove = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPositionStart = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPositionActualValue = new System.Windows.Forms.TextBox();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonEnable = new System.Windows.Forms.Button();
            this.buttonDisable = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.buttonHalt = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxNodeId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxAOM);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            //
            // textBoxAOM
            //
            this.textBoxAOM.Location = new System.Drawing.Point(138, 36);
            this.textBoxAOM.Name = "textBoxAOM";
            this.textBoxAOM.ReadOnly = true;
            this.textBoxAOM.Size = new System.Drawing.Size(170, 20);
            this.textBoxAOM.TabIndex = 0;
            this.textBoxAOM.Text = "Unknown";
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Active Operation Mode:";
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NodeID:";
            //
            // textBoxNodeId
            //
            this.textBoxNodeId.Location = new System.Drawing.Point(138, 77);
            this.textBoxNodeId.Name = "textBoxNodeId";
            this.textBoxNodeId.Size = new System.Drawing.Size(57, 20);
            this.textBoxNodeId.TabIndex = 0;
            this.textBoxNodeId.Text = "1";
            //
            // groupBox2
            //
            this.groupBox2.Controls.Add(this.radioButtonAbsoluteMove);
            this.groupBox2.Controls.Add(this.radioButtonRelativeMode);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBoxTargetPosition);
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 120);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profile Position Mode";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Target Position:";
            //
            // textBoxTargetPosition
            //
            this.textBoxTargetPosition.Location = new System.Drawing.Point(138, 31);
            this.textBoxTargetPosition.Name = "textBoxTargetPosition";
            this.textBoxTargetPosition.Size = new System.Drawing.Size(82, 20);
            this.textBoxTargetPosition.TabIndex = 0;
            this.textBoxTargetPosition.Text = "2000";
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "qc";
            //
            // radioButtonRelativeMode
            //
            this.radioButtonRelativeMode.AutoSize = true;
            this.radioButtonRelativeMode.Location = new System.Drawing.Point(138, 69);
            this.radioButtonRelativeMode.Name = "radioButtonRelativeMode";
            this.radioButtonRelativeMode.Size = new System.Drawing.Size(64, 17);
            this.radioButtonRelativeMode.TabIndex = 1;
            this.radioButtonRelativeMode.TabStop = true;
            this.radioButtonRelativeMode.Text = "&Relative";
            this.radioButtonRelativeMode.UseVisualStyleBackColor = true;

            //
            // radioButtonAbsoluteMove
            //
            this.radioButtonAbsoluteMove.AutoSize = true;
            this.radioButtonAbsoluteMove.Location = new System.Drawing.Point(138, 92);
            this.radioButtonAbsoluteMove.Name = "radioButtonAbsoluteMove";
            this.radioButtonAbsoluteMove.Size = new System.Drawing.Size(66, 17);
            this.radioButtonAbsoluteMove.TabIndex = 2;
            this.radioButtonAbsoluteMove.TabStop = true;
            this.radioButtonAbsoluteMove.Text = "&Absolute";
            this.radioButtonAbsoluteMove.UseVisualStyleBackColor = true;
            //
            // groupBox3
            //
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxPositionActualValue);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxPositionStart);
            this.groupBox3.Location = new System.Drawing.Point(12, 305);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 114);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actual Values";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Position Start:";
            //
            // textBoxPositionStart
            //
            this.textBoxPositionStart.Location = new System.Drawing.Point(144, 42);
            this.textBoxPositionStart.Name = "textBoxPositionStart";
            this.textBoxPositionStart.ReadOnly = true;
            this.textBoxPositionStart.Size = new System.Drawing.Size(164, 20);
            this.textBoxPositionStart.TabIndex = 2;
            this.textBoxPositionStart.Text = "0";
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "qc";
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "qc";
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Position Actual Value:";
            //
            // textBoxPositionActualValue
            //
            this.textBoxPositionActualValue.Location = new System.Drawing.Point(144, 68);
            this.textBoxPositionActualValue.Name = "textBoxPositionActualValue";
            this.textBoxPositionActualValue.ReadOnly = true;
            this.textBoxPositionActualValue.Size = new System.Drawing.Size(164, 20);
            this.textBoxPositionActualValue.TabIndex = 8;
            this.textBoxPositionActualValue.Text = "0";
            //
            // buttonSettings
            //
            this.buttonSettings.Location = new System.Drawing.Point(403, 35);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(146, 28);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.Text = "Device &Settings";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettingsClick);
            //
            // buttonEnable
            //
            this.buttonEnable.Enabled = false;
            this.buttonEnable.Location = new System.Drawing.Point(403, 82);
            this.buttonEnable.Name = "buttonEnable";
            this.buttonEnable.Size = new System.Drawing.Size(146, 28);
            this.buttonEnable.TabIndex = 1;
            this.buttonEnable.Text = "&Enable";
            this.buttonEnable.UseVisualStyleBackColor = true;
            this.buttonEnable.Click += new System.EventHandler(this.ButtonEnableClick);
            //
            // buttonDisable
            //
            this.buttonDisable.Enabled = false;
            this.buttonDisable.Location = new System.Drawing.Point(403, 116);
            this.buttonDisable.Name = "buttonDisable";
            this.buttonDisable.Size = new System.Drawing.Size(146, 28);
            this.buttonDisable.TabIndex = 2;
            this.buttonDisable.Text = "&Disable";
            this.buttonDisable.UseVisualStyleBackColor = true;
            this.buttonDisable.Click += new System.EventHandler(this.ButtonDisableClick);
            //
            // buttonMove
            //
            this.buttonMove.Enabled = false;
            this.buttonMove.Location = new System.Drawing.Point(403, 185);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(146, 28);
            this.buttonMove.TabIndex = 3;
            this.buttonMove.Text = "&Move";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.ButtonMoveClick);
            //
            // buttonHalt
            //
            this.buttonHalt.Enabled = false;
            this.buttonHalt.Location = new System.Drawing.Point(403, 219);
            this.buttonHalt.Name = "buttonHalt";
            this.buttonHalt.Size = new System.Drawing.Size(146, 28);
            this.buttonHalt.TabIndex = 4;
            this.buttonHalt.Text = "&Halt";
            this.buttonHalt.UseVisualStyleBackColor = true;
            this.buttonHalt.Click += new System.EventHandler(this.ButtonHaltClick);
            //
            // buttonExit
            //
            this.buttonExit.Location = new System.Drawing.Point(403, 391);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(146, 28);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exi&t";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            //
            // timer1
            //
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 444);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonHalt);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonDisable);
            this.Controls.Add(this.buttonEnable);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Demo EposCmd.Net / .NET Framework 2.0 / C# example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTargetPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNodeId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAOM;
        private System.Windows.Forms.RadioButton radioButtonRelativeMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonAbsoluteMove;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPositionActualValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPositionStart;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonEnable;
        private System.Windows.Forms.Button buttonDisable;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Button buttonHalt;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer timer1;
    }
}

