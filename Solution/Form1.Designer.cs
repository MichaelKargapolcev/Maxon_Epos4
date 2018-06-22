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
            this.groupBox1_A = new System.Windows.Forms.GroupBox();
            this.label2_A = new System.Windows.Forms.Label();
            this.buttonDisable_A = new System.Windows.Forms.Button();
            this.textBoxNodeId_A = new System.Windows.Forms.TextBox();
            this.buttonEnable_A = new System.Windows.Forms.Button();
            this.label1_A = new System.Windows.Forms.Label();
            this.buttonSettings_A = new System.Windows.Forms.Button();
            this.textBoxAOM_A = new System.Windows.Forms.TextBox();
            this.groupBox2_A = new System.Windows.Forms.GroupBox();
            this.radioButtonAbsoluteMove_A = new System.Windows.Forms.RadioButton();
            this.buttonHalt_A = new System.Windows.Forms.Button();
            this.buttonMove_A = new System.Windows.Forms.Button();
            this.radioButtonRelativeMode_A = new System.Windows.Forms.RadioButton();
            this.label5_A = new System.Windows.Forms.Label();
            this.label3_A = new System.Windows.Forms.Label();
            this.textBoxTargetPosition_A = new System.Windows.Forms.TextBox();
            this.groupBox3_A = new System.Windows.Forms.GroupBox();
            this.label7_A = new System.Windows.Forms.Label();
            this.label8_A = new System.Windows.Forms.Label();
            this.textBoxPositionActualValue_A = new System.Windows.Forms.TextBox();
            this.label6_A = new System.Windows.Forms.Label();
            this.label4_A = new System.Windows.Forms.Label();
            this.textBoxPositionStart_A = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.timer_A = new System.Windows.Forms.Timer(this.components);
            this.groupBox3_B = new System.Windows.Forms.GroupBox();
            this.label7_B = new System.Windows.Forms.Label();
            this.label8_B = new System.Windows.Forms.Label();
            this.textBoxPositionActualValue_B = new System.Windows.Forms.TextBox();
            this.label6_B = new System.Windows.Forms.Label();
            this.label4_B = new System.Windows.Forms.Label();
            this.textBoxPositionStart_B = new System.Windows.Forms.TextBox();
            this.groupBox2_B = new System.Windows.Forms.GroupBox();
            this.radioButtonAbsoluteMove_B = new System.Windows.Forms.RadioButton();
            this.buttonHalt_B = new System.Windows.Forms.Button();
            this.buttonMove_B = new System.Windows.Forms.Button();
            this.radioButtonRelativeMode_B = new System.Windows.Forms.RadioButton();
            this.label5_B = new System.Windows.Forms.Label();
            this.label3_B = new System.Windows.Forms.Label();
            this.textBoxTargetPosition_B = new System.Windows.Forms.TextBox();
            this.groupBox1_B = new System.Windows.Forms.GroupBox();
            this.label_B = new System.Windows.Forms.Label();
            this.buttonDisable_B = new System.Windows.Forms.Button();
            this.textBoxNodeId_B = new System.Windows.Forms.TextBox();
            this.buttonEnable_B = new System.Windows.Forms.Button();
            this.label1_B = new System.Windows.Forms.Label();
            this.buttonSettings_B = new System.Windows.Forms.Button();
            this.textBoxAOM_B = new System.Windows.Forms.TextBox();
            this.timer_B = new System.Windows.Forms.Timer(this.components);
            this.checkBox_use_joy = new System.Windows.Forms.CheckBox();
            this.label_right_trigger = new System.Windows.Forms.Label();
            this.label_left_trigger = new System.Windows.Forms.Label();
            this.label_right_axis_y = new System.Windows.Forms.Label();
            this.label_right_axis_x = new System.Windows.Forms.Label();
            this.label_left_axis_y = new System.Windows.Forms.Label();
            this.label_left_axis_x = new System.Windows.Forms.Label();
            this.groupBox1_A.SuspendLayout();
            this.groupBox2_A.SuspendLayout();
            this.groupBox3_A.SuspendLayout();
            this.groupBox3_B.SuspendLayout();
            this.groupBox2_B.SuspendLayout();
            this.groupBox1_B.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1_A
            // 
            this.groupBox1_A.Controls.Add(this.label2_A);
            this.groupBox1_A.Controls.Add(this.buttonDisable_A);
            this.groupBox1_A.Controls.Add(this.textBoxNodeId_A);
            this.groupBox1_A.Controls.Add(this.buttonEnable_A);
            this.groupBox1_A.Controls.Add(this.label1_A);
            this.groupBox1_A.Controls.Add(this.buttonSettings_A);
            this.groupBox1_A.Controls.Add(this.textBoxAOM_A);
            this.groupBox1_A.Location = new System.Drawing.Point(9, 9);
            this.groupBox1_A.Name = "groupBox1_A";
            this.groupBox1_A.Size = new System.Drawing.Size(214, 120);
            this.groupBox1_A.TabIndex = 0;
            this.groupBox1_A.TabStop = false;
            this.groupBox1_A.Text = "Settings";
            // 
            // label2_A
            // 
            this.label2_A.AutoSize = true;
            this.label2_A.Location = new System.Drawing.Point(5, 58);
            this.label2_A.Name = "label2_A";
            this.label2_A.Size = new System.Drawing.Size(47, 13);
            this.label2_A.TabIndex = 3;
            this.label2_A.Text = "NodeID:";
            // 
            // buttonDisable_A
            // 
            this.buttonDisable_A.Enabled = false;
            this.buttonDisable_A.Location = new System.Drawing.Point(133, 85);
            this.buttonDisable_A.Name = "buttonDisable_A";
            this.buttonDisable_A.Size = new System.Drawing.Size(51, 28);
            this.buttonDisable_A.TabIndex = 2;
            this.buttonDisable_A.Text = "&Disable";
            this.buttonDisable_A.UseVisualStyleBackColor = true;
            this.buttonDisable_A.Click += new System.EventHandler(this.ButtonDisable_A_Click);
            // 
            // textBoxNodeId_A
            // 
            this.textBoxNodeId_A.Location = new System.Drawing.Point(71, 54);
            this.textBoxNodeId_A.Name = "textBoxNodeId_A";
            this.textBoxNodeId_A.Size = new System.Drawing.Size(57, 20);
            this.textBoxNodeId_A.TabIndex = 0;
            this.textBoxNodeId_A.Text = "1";
            // 
            // buttonEnable_A
            // 
            this.buttonEnable_A.Enabled = false;
            this.buttonEnable_A.Location = new System.Drawing.Point(133, 51);
            this.buttonEnable_A.Name = "buttonEnable_A";
            this.buttonEnable_A.Size = new System.Drawing.Size(51, 28);
            this.buttonEnable_A.TabIndex = 1;
            this.buttonEnable_A.Text = "&Enable";
            this.buttonEnable_A.UseVisualStyleBackColor = true;
            this.buttonEnable_A.Click += new System.EventHandler(this.ButtonEnable_A_Click);
            // 
            // label1_A
            // 
            this.label1_A.AutoSize = true;
            this.label1_A.Location = new System.Drawing.Point(5, 18);
            this.label1_A.Name = "label1_A";
            this.label1_A.Size = new System.Drawing.Size(119, 13);
            this.label1_A.TabIndex = 1;
            this.label1_A.Text = "Active Operation Mode:";
            // 
            // buttonSettings_A
            // 
            this.buttonSettings_A.Location = new System.Drawing.Point(133, 18);
            this.buttonSettings_A.Name = "buttonSettings_A";
            this.buttonSettings_A.Size = new System.Drawing.Size(51, 28);
            this.buttonSettings_A.TabIndex = 0;
            this.buttonSettings_A.Text = "Device &Settings";
            this.buttonSettings_A.UseVisualStyleBackColor = true;
            this.buttonSettings_A.Click += new System.EventHandler(this.ButtonSettings_A_Click);
            // 
            // textBoxAOM_A
            // 
            this.textBoxAOM_A.Location = new System.Drawing.Point(5, 34);
            this.textBoxAOM_A.Name = "textBoxAOM_A";
            this.textBoxAOM_A.ReadOnly = true;
            this.textBoxAOM_A.Size = new System.Drawing.Size(123, 20);
            this.textBoxAOM_A.TabIndex = 0;
            this.textBoxAOM_A.Text = "Unknown";
            // 
            // groupBox2_A
            // 
            this.groupBox2_A.Controls.Add(this.radioButtonAbsoluteMove_A);
            this.groupBox2_A.Controls.Add(this.buttonHalt_A);
            this.groupBox2_A.Controls.Add(this.buttonMove_A);
            this.groupBox2_A.Controls.Add(this.radioButtonRelativeMode_A);
            this.groupBox2_A.Controls.Add(this.label5_A);
            this.groupBox2_A.Controls.Add(this.label3_A);
            this.groupBox2_A.Controls.Add(this.textBoxTargetPosition_A);
            this.groupBox2_A.Location = new System.Drawing.Point(9, 136);
            this.groupBox2_A.Name = "groupBox2_A";
            this.groupBox2_A.Size = new System.Drawing.Size(214, 133);
            this.groupBox2_A.TabIndex = 4;
            this.groupBox2_A.TabStop = false;
            this.groupBox2_A.Text = "Profile Position Mode";
            // 
            // radioButtonAbsoluteMove_A
            // 
            this.radioButtonAbsoluteMove_A.AutoSize = true;
            this.radioButtonAbsoluteMove_A.Location = new System.Drawing.Point(16, 105);
            this.radioButtonAbsoluteMove_A.Name = "radioButtonAbsoluteMove_A";
            this.radioButtonAbsoluteMove_A.Size = new System.Drawing.Size(66, 17);
            this.radioButtonAbsoluteMove_A.TabIndex = 2;
            this.radioButtonAbsoluteMove_A.TabStop = true;
            this.radioButtonAbsoluteMove_A.Text = "&Absolute";
            this.radioButtonAbsoluteMove_A.UseVisualStyleBackColor = true;
            // 
            // buttonHalt_A
            // 
            this.buttonHalt_A.Enabled = false;
            this.buttonHalt_A.Location = new System.Drawing.Point(138, 76);
            this.buttonHalt_A.Name = "buttonHalt_A";
            this.buttonHalt_A.Size = new System.Drawing.Size(46, 28);
            this.buttonHalt_A.TabIndex = 4;
            this.buttonHalt_A.Text = "&Halt";
            this.buttonHalt_A.UseVisualStyleBackColor = true;
            this.buttonHalt_A.Click += new System.EventHandler(this.ButtonHalt_A_Click);
            // 
            // buttonMove_A
            // 
            this.buttonMove_A.Enabled = false;
            this.buttonMove_A.Location = new System.Drawing.Point(138, 42);
            this.buttonMove_A.Name = "buttonMove_A";
            this.buttonMove_A.Size = new System.Drawing.Size(46, 28);
            this.buttonMove_A.TabIndex = 3;
            this.buttonMove_A.Text = "&Move";
            this.buttonMove_A.UseVisualStyleBackColor = true;
            this.buttonMove_A.Click += new System.EventHandler(this.ButtonMove_A_Click);
            // 
            // radioButtonRelativeMode_A
            // 
            this.radioButtonRelativeMode_A.AutoSize = true;
            this.radioButtonRelativeMode_A.Location = new System.Drawing.Point(16, 82);
            this.radioButtonRelativeMode_A.Name = "radioButtonRelativeMode_A";
            this.radioButtonRelativeMode_A.Size = new System.Drawing.Size(64, 17);
            this.radioButtonRelativeMode_A.TabIndex = 1;
            this.radioButtonRelativeMode_A.TabStop = true;
            this.radioButtonRelativeMode_A.Text = "&Relative";
            this.radioButtonRelativeMode_A.UseVisualStyleBackColor = true;
            // 
            // label5_A
            // 
            this.label5_A.AutoSize = true;
            this.label5_A.Location = new System.Drawing.Point(102, 60);
            this.label5_A.Name = "label5_A";
            this.label5_A.Size = new System.Drawing.Size(19, 13);
            this.label5_A.TabIndex = 4;
            this.label5_A.Text = "qc";
            // 
            // label3_A
            // 
            this.label3_A.AutoSize = true;
            this.label3_A.Location = new System.Drawing.Point(13, 34);
            this.label3_A.Name = "label3_A";
            this.label3_A.Size = new System.Drawing.Size(81, 13);
            this.label3_A.TabIndex = 3;
            this.label3_A.Text = "Target Position:";
            // 
            // textBoxTargetPosition_A
            // 
            this.textBoxTargetPosition_A.Location = new System.Drawing.Point(16, 58);
            this.textBoxTargetPosition_A.Name = "textBoxTargetPosition_A";
            this.textBoxTargetPosition_A.Size = new System.Drawing.Size(82, 20);
            this.textBoxTargetPosition_A.TabIndex = 0;
            this.textBoxTargetPosition_A.Text = "2000";
            // 
            // groupBox3_A
            // 
            this.groupBox3_A.Controls.Add(this.label7_A);
            this.groupBox3_A.Controls.Add(this.label8_A);
            this.groupBox3_A.Controls.Add(this.textBoxPositionActualValue_A);
            this.groupBox3_A.Controls.Add(this.label6_A);
            this.groupBox3_A.Controls.Add(this.label4_A);
            this.groupBox3_A.Controls.Add(this.textBoxPositionStart_A);
            this.groupBox3_A.Location = new System.Drawing.Point(9, 275);
            this.groupBox3_A.Name = "groupBox3_A";
            this.groupBox3_A.Size = new System.Drawing.Size(214, 114);
            this.groupBox3_A.TabIndex = 5;
            this.groupBox3_A.TabStop = false;
            this.groupBox3_A.Text = "Actual Values";
            // 
            // label7_A
            // 
            this.label7_A.AutoSize = true;
            this.label7_A.Location = new System.Drawing.Point(179, 82);
            this.label7_A.Name = "label7_A";
            this.label7_A.Size = new System.Drawing.Size(19, 13);
            this.label7_A.TabIndex = 10;
            this.label7_A.Text = "qc";
            // 
            // label8_A
            // 
            this.label8_A.AutoSize = true;
            this.label8_A.Location = new System.Drawing.Point(9, 66);
            this.label8_A.Name = "label8_A";
            this.label8_A.Size = new System.Drawing.Size(110, 13);
            this.label8_A.TabIndex = 9;
            this.label8_A.Text = "Position Actual Value:";
            // 
            // textBoxPositionActualValue_A
            // 
            this.textBoxPositionActualValue_A.Location = new System.Drawing.Point(11, 82);
            this.textBoxPositionActualValue_A.Name = "textBoxPositionActualValue_A";
            this.textBoxPositionActualValue_A.ReadOnly = true;
            this.textBoxPositionActualValue_A.Size = new System.Drawing.Size(164, 20);
            this.textBoxPositionActualValue_A.TabIndex = 8;
            this.textBoxPositionActualValue_A.Text = "0";
            // 
            // label6_A
            // 
            this.label6_A.AutoSize = true;
            this.label6_A.Location = new System.Drawing.Point(179, 42);
            this.label6_A.Name = "label6_A";
            this.label6_A.Size = new System.Drawing.Size(19, 13);
            this.label6_A.TabIndex = 7;
            this.label6_A.Text = "qc";
            // 
            // label4_A
            // 
            this.label4_A.AutoSize = true;
            this.label4_A.Location = new System.Drawing.Point(9, 24);
            this.label4_A.Name = "label4_A";
            this.label4_A.Size = new System.Drawing.Size(72, 13);
            this.label4_A.TabIndex = 3;
            this.label4_A.Text = "Position Start:";
            // 
            // textBoxPositionStart_A
            // 
            this.textBoxPositionStart_A.Location = new System.Drawing.Point(11, 40);
            this.textBoxPositionStart_A.Name = "textBoxPositionStart_A";
            this.textBoxPositionStart_A.ReadOnly = true;
            this.textBoxPositionStart_A.Size = new System.Drawing.Size(164, 20);
            this.textBoxPositionStart_A.TabIndex = 2;
            this.textBoxPositionStart_A.Text = "0";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(407, 399);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(46, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exi&t";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // timer_A
            // 
            this.timer_A.Tick += new System.EventHandler(this.Timer_A_Tick);
            // 
            // groupBox3_B
            // 
            this.groupBox3_B.Controls.Add(this.label7_B);
            this.groupBox3_B.Controls.Add(this.label8_B);
            this.groupBox3_B.Controls.Add(this.textBoxPositionActualValue_B);
            this.groupBox3_B.Controls.Add(this.label6_B);
            this.groupBox3_B.Controls.Add(this.label4_B);
            this.groupBox3_B.Controls.Add(this.textBoxPositionStart_B);
            this.groupBox3_B.Location = new System.Drawing.Point(239, 275);
            this.groupBox3_B.Name = "groupBox3_B";
            this.groupBox3_B.Size = new System.Drawing.Size(214, 114);
            this.groupBox3_B.TabIndex = 13;
            this.groupBox3_B.TabStop = false;
            this.groupBox3_B.Text = "Actual Values";
            // 
            // label7_B
            // 
            this.label7_B.AutoSize = true;
            this.label7_B.Location = new System.Drawing.Point(179, 82);
            this.label7_B.Name = "label7_B";
            this.label7_B.Size = new System.Drawing.Size(19, 13);
            this.label7_B.TabIndex = 10;
            this.label7_B.Text = "qc";
            // 
            // label8_B
            // 
            this.label8_B.AutoSize = true;
            this.label8_B.Location = new System.Drawing.Point(9, 66);
            this.label8_B.Name = "label8_B";
            this.label8_B.Size = new System.Drawing.Size(110, 13);
            this.label8_B.TabIndex = 9;
            this.label8_B.Text = "Position Actual Value:";
            // 
            // textBoxPositionActualValue_B
            // 
            this.textBoxPositionActualValue_B.Location = new System.Drawing.Point(11, 82);
            this.textBoxPositionActualValue_B.Name = "textBoxPositionActualValue_B";
            this.textBoxPositionActualValue_B.ReadOnly = true;
            this.textBoxPositionActualValue_B.Size = new System.Drawing.Size(164, 20);
            this.textBoxPositionActualValue_B.TabIndex = 8;
            this.textBoxPositionActualValue_B.Text = "0";
            // 
            // label6_B
            // 
            this.label6_B.AutoSize = true;
            this.label6_B.Location = new System.Drawing.Point(179, 42);
            this.label6_B.Name = "label6_B";
            this.label6_B.Size = new System.Drawing.Size(19, 13);
            this.label6_B.TabIndex = 7;
            this.label6_B.Text = "qc";
            // 
            // label4_B
            // 
            this.label4_B.AutoSize = true;
            this.label4_B.Location = new System.Drawing.Point(9, 24);
            this.label4_B.Name = "label4_B";
            this.label4_B.Size = new System.Drawing.Size(72, 13);
            this.label4_B.TabIndex = 3;
            this.label4_B.Text = "Position Start:";
            // 
            // textBoxPositionStart_B
            // 
            this.textBoxPositionStart_B.Location = new System.Drawing.Point(11, 40);
            this.textBoxPositionStart_B.Name = "textBoxPositionStart_B";
            this.textBoxPositionStart_B.ReadOnly = true;
            this.textBoxPositionStart_B.Size = new System.Drawing.Size(164, 20);
            this.textBoxPositionStart_B.TabIndex = 2;
            this.textBoxPositionStart_B.Text = "0";
            // 
            // groupBox2_B
            // 
            this.groupBox2_B.Controls.Add(this.radioButtonAbsoluteMove_B);
            this.groupBox2_B.Controls.Add(this.buttonHalt_B);
            this.groupBox2_B.Controls.Add(this.buttonMove_B);
            this.groupBox2_B.Controls.Add(this.radioButtonRelativeMode_B);
            this.groupBox2_B.Controls.Add(this.label5_B);
            this.groupBox2_B.Controls.Add(this.label3_B);
            this.groupBox2_B.Controls.Add(this.textBoxTargetPosition_B);
            this.groupBox2_B.Location = new System.Drawing.Point(239, 136);
            this.groupBox2_B.Name = "groupBox2_B";
            this.groupBox2_B.Size = new System.Drawing.Size(214, 133);
            this.groupBox2_B.TabIndex = 12;
            this.groupBox2_B.TabStop = false;
            this.groupBox2_B.Text = "Profile Position Mode";
            // 
            // radioButtonAbsoluteMove_B
            // 
            this.radioButtonAbsoluteMove_B.AutoSize = true;
            this.radioButtonAbsoluteMove_B.Location = new System.Drawing.Point(16, 105);
            this.radioButtonAbsoluteMove_B.Name = "radioButtonAbsoluteMove_B";
            this.radioButtonAbsoluteMove_B.Size = new System.Drawing.Size(66, 17);
            this.radioButtonAbsoluteMove_B.TabIndex = 2;
            this.radioButtonAbsoluteMove_B.TabStop = true;
            this.radioButtonAbsoluteMove_B.Text = "&Absolute";
            this.radioButtonAbsoluteMove_B.UseVisualStyleBackColor = true;
            // 
            // buttonHalt_B
            // 
            this.buttonHalt_B.Enabled = false;
            this.buttonHalt_B.Location = new System.Drawing.Point(138, 76);
            this.buttonHalt_B.Name = "buttonHalt_B";
            this.buttonHalt_B.Size = new System.Drawing.Size(46, 28);
            this.buttonHalt_B.TabIndex = 4;
            this.buttonHalt_B.Text = "&Halt";
            this.buttonHalt_B.UseVisualStyleBackColor = true;
            this.buttonHalt_B.Click += new System.EventHandler(this.buttonHalt_B_Click);
            // 
            // buttonMove_B
            // 
            this.buttonMove_B.Enabled = false;
            this.buttonMove_B.Location = new System.Drawing.Point(138, 42);
            this.buttonMove_B.Name = "buttonMove_B";
            this.buttonMove_B.Size = new System.Drawing.Size(46, 28);
            this.buttonMove_B.TabIndex = 3;
            this.buttonMove_B.Text = "&Move";
            this.buttonMove_B.UseVisualStyleBackColor = true;
            this.buttonMove_B.Click += new System.EventHandler(this.buttonMove_B_Click);
            // 
            // radioButtonRelativeMode_B
            // 
            this.radioButtonRelativeMode_B.AutoSize = true;
            this.radioButtonRelativeMode_B.Location = new System.Drawing.Point(16, 82);
            this.radioButtonRelativeMode_B.Name = "radioButtonRelativeMode_B";
            this.radioButtonRelativeMode_B.Size = new System.Drawing.Size(64, 17);
            this.radioButtonRelativeMode_B.TabIndex = 1;
            this.radioButtonRelativeMode_B.TabStop = true;
            this.radioButtonRelativeMode_B.Text = "&Relative";
            this.radioButtonRelativeMode_B.UseVisualStyleBackColor = true;
            // 
            // label5_B
            // 
            this.label5_B.AutoSize = true;
            this.label5_B.Location = new System.Drawing.Point(102, 60);
            this.label5_B.Name = "label5_B";
            this.label5_B.Size = new System.Drawing.Size(19, 13);
            this.label5_B.TabIndex = 4;
            this.label5_B.Text = "qc";
            // 
            // label3_B
            // 
            this.label3_B.AutoSize = true;
            this.label3_B.Location = new System.Drawing.Point(13, 34);
            this.label3_B.Name = "label3_B";
            this.label3_B.Size = new System.Drawing.Size(81, 13);
            this.label3_B.TabIndex = 3;
            this.label3_B.Text = "Target Position:";
            // 
            // textBoxTargetPosition_B
            // 
            this.textBoxTargetPosition_B.Location = new System.Drawing.Point(16, 58);
            this.textBoxTargetPosition_B.Name = "textBoxTargetPosition_B";
            this.textBoxTargetPosition_B.Size = new System.Drawing.Size(82, 20);
            this.textBoxTargetPosition_B.TabIndex = 0;
            this.textBoxTargetPosition_B.Text = "2000";
            // 
            // groupBox1_B
            // 
            this.groupBox1_B.Controls.Add(this.label_B);
            this.groupBox1_B.Controls.Add(this.buttonDisable_B);
            this.groupBox1_B.Controls.Add(this.textBoxNodeId_B);
            this.groupBox1_B.Controls.Add(this.buttonEnable_B);
            this.groupBox1_B.Controls.Add(this.label1_B);
            this.groupBox1_B.Controls.Add(this.buttonSettings_B);
            this.groupBox1_B.Controls.Add(this.textBoxAOM_B);
            this.groupBox1_B.Location = new System.Drawing.Point(239, 9);
            this.groupBox1_B.Name = "groupBox1_B";
            this.groupBox1_B.Size = new System.Drawing.Size(214, 120);
            this.groupBox1_B.TabIndex = 11;
            this.groupBox1_B.TabStop = false;
            this.groupBox1_B.Text = "Settings";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Location = new System.Drawing.Point(5, 58);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(47, 13);
            this.label_B.TabIndex = 3;
            this.label_B.Text = "NodeID:";
            // 
            // buttonDisable_B
            // 
            this.buttonDisable_B.Enabled = false;
            this.buttonDisable_B.Location = new System.Drawing.Point(133, 85);
            this.buttonDisable_B.Name = "buttonDisable_B";
            this.buttonDisable_B.Size = new System.Drawing.Size(51, 28);
            this.buttonDisable_B.TabIndex = 2;
            this.buttonDisable_B.Text = "&Disable";
            this.buttonDisable_B.UseVisualStyleBackColor = true;
            this.buttonDisable_B.Click += new System.EventHandler(this.buttonDisable_B_Click);
            // 
            // textBoxNodeId_B
            // 
            this.textBoxNodeId_B.Location = new System.Drawing.Point(71, 54);
            this.textBoxNodeId_B.Name = "textBoxNodeId_B";
            this.textBoxNodeId_B.Size = new System.Drawing.Size(57, 20);
            this.textBoxNodeId_B.TabIndex = 0;
            this.textBoxNodeId_B.Text = "1";
            // 
            // buttonEnable_B
            // 
            this.buttonEnable_B.Enabled = false;
            this.buttonEnable_B.Location = new System.Drawing.Point(133, 51);
            this.buttonEnable_B.Name = "buttonEnable_B";
            this.buttonEnable_B.Size = new System.Drawing.Size(51, 28);
            this.buttonEnable_B.TabIndex = 1;
            this.buttonEnable_B.Text = "&Enable";
            this.buttonEnable_B.UseVisualStyleBackColor = true;
            this.buttonEnable_B.Click += new System.EventHandler(this.buttonEnable_B_Click);
            // 
            // label1_B
            // 
            this.label1_B.AutoSize = true;
            this.label1_B.Location = new System.Drawing.Point(5, 18);
            this.label1_B.Name = "label1_B";
            this.label1_B.Size = new System.Drawing.Size(119, 13);
            this.label1_B.TabIndex = 1;
            this.label1_B.Text = "Active Operation Mode:";
            // 
            // buttonSettings_B
            // 
            this.buttonSettings_B.Location = new System.Drawing.Point(133, 18);
            this.buttonSettings_B.Name = "buttonSettings_B";
            this.buttonSettings_B.Size = new System.Drawing.Size(51, 28);
            this.buttonSettings_B.TabIndex = 0;
            this.buttonSettings_B.Text = "Device &Settings";
            this.buttonSettings_B.UseVisualStyleBackColor = true;
            this.buttonSettings_B.Click += new System.EventHandler(this.buttonSettings_B_Click);
            // 
            // textBoxAOM_B
            // 
            this.textBoxAOM_B.Location = new System.Drawing.Point(5, 34);
            this.textBoxAOM_B.Name = "textBoxAOM_B";
            this.textBoxAOM_B.ReadOnly = true;
            this.textBoxAOM_B.Size = new System.Drawing.Size(123, 20);
            this.textBoxAOM_B.TabIndex = 0;
            this.textBoxAOM_B.Text = "Unknown";
            // 
            // timer_B
            // 
            this.timer_B.Tick += new System.EventHandler(this.Timer_B_ick);
            // 
            // checkBox_use_joy
            // 
            this.checkBox_use_joy.AutoSize = true;
            this.checkBox_use_joy.Location = new System.Drawing.Point(21, 405);
            this.checkBox_use_joy.Name = "checkBox_use_joy";
            this.checkBox_use_joy.Size = new System.Drawing.Size(110, 17);
            this.checkBox_use_joy.TabIndex = 14;
            this.checkBox_use_joy.Text = "use xBox Joystick";
            this.checkBox_use_joy.UseVisualStyleBackColor = true;
            // 
            // label_right_trigger
            // 
            this.label_right_trigger.AutoSize = true;
            this.label_right_trigger.Location = new System.Drawing.Point(77, 440);
            this.label_right_trigger.Name = "label_right_trigger";
            this.label_right_trigger.Size = new System.Drawing.Size(22, 13);
            this.label_right_trigger.TabIndex = 20;
            this.label_right_trigger.Text = "-----";
            // 
            // label_left_trigger
            // 
            this.label_left_trigger.AutoSize = true;
            this.label_left_trigger.Location = new System.Drawing.Point(22, 440);
            this.label_left_trigger.Name = "label_left_trigger";
            this.label_left_trigger.Size = new System.Drawing.Size(22, 13);
            this.label_left_trigger.TabIndex = 19;
            this.label_left_trigger.Text = "-----";
            // 
            // label_right_axis_y
            // 
            this.label_right_axis_y.AutoSize = true;
            this.label_right_axis_y.Location = new System.Drawing.Point(77, 488);
            this.label_right_axis_y.Name = "label_right_axis_y";
            this.label_right_axis_y.Size = new System.Drawing.Size(22, 13);
            this.label_right_axis_y.TabIndex = 18;
            this.label_right_axis_y.Text = "-----";
            // 
            // label_right_axis_x
            // 
            this.label_right_axis_x.AutoSize = true;
            this.label_right_axis_x.Location = new System.Drawing.Point(77, 466);
            this.label_right_axis_x.Name = "label_right_axis_x";
            this.label_right_axis_x.Size = new System.Drawing.Size(22, 13);
            this.label_right_axis_x.TabIndex = 17;
            this.label_right_axis_x.Text = "-----";
            // 
            // label_left_axis_y
            // 
            this.label_left_axis_y.AutoSize = true;
            this.label_left_axis_y.Location = new System.Drawing.Point(22, 488);
            this.label_left_axis_y.Name = "label_left_axis_y";
            this.label_left_axis_y.Size = new System.Drawing.Size(22, 13);
            this.label_left_axis_y.TabIndex = 16;
            this.label_left_axis_y.Text = "-----";
            // 
            // label_left_axis_x
            // 
            this.label_left_axis_x.AutoSize = true;
            this.label_left_axis_x.Location = new System.Drawing.Point(22, 466);
            this.label_left_axis_x.Name = "label_left_axis_x";
            this.label_left_axis_x.Size = new System.Drawing.Size(22, 13);
            this.label_left_axis_x.TabIndex = 15;
            this.label_left_axis_x.Text = "-----";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 519);
            this.Controls.Add(this.label_right_trigger);
            this.Controls.Add(this.label_left_trigger);
            this.Controls.Add(this.label_right_axis_y);
            this.Controls.Add(this.label_right_axis_x);
            this.Controls.Add(this.label_left_axis_y);
            this.Controls.Add(this.label_left_axis_x);
            this.Controls.Add(this.checkBox_use_joy);
            this.Controls.Add(this.groupBox3_B);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox2_B);
            this.Controls.Add(this.groupBox3_A);
            this.Controls.Add(this.groupBox1_B);
            this.Controls.Add(this.groupBox2_A);
            this.Controls.Add(this.groupBox1_A);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1_A.ResumeLayout(false);
            this.groupBox1_A.PerformLayout();
            this.groupBox2_A.ResumeLayout(false);
            this.groupBox2_A.PerformLayout();
            this.groupBox3_A.ResumeLayout(false);
            this.groupBox3_A.PerformLayout();
            this.groupBox3_B.ResumeLayout(false);
            this.groupBox3_B.PerformLayout();
            this.groupBox2_B.ResumeLayout(false);
            this.groupBox2_B.PerformLayout();
            this.groupBox1_B.ResumeLayout(false);
            this.groupBox1_B.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1_A;
        private System.Windows.Forms.GroupBox groupBox2_A;
        private System.Windows.Forms.Label label3_A;
        private System.Windows.Forms.TextBox textBoxTargetPosition_A;
        private System.Windows.Forms.Label label2_A;
        private System.Windows.Forms.TextBox textBoxNodeId_A;
        private System.Windows.Forms.Label label1_A;
        private System.Windows.Forms.TextBox textBoxAOM_A;
        private System.Windows.Forms.RadioButton radioButtonRelativeMode_A;
        private System.Windows.Forms.Label label5_A;
        private System.Windows.Forms.RadioButton radioButtonAbsoluteMove_A;
        private System.Windows.Forms.GroupBox groupBox3_A;
        private System.Windows.Forms.Label label7_A;
        private System.Windows.Forms.Label label8_A;
        private System.Windows.Forms.TextBox textBoxPositionActualValue_A;
        private System.Windows.Forms.Label label6_A;
        private System.Windows.Forms.Label label4_A;
        private System.Windows.Forms.TextBox textBoxPositionStart_A;
        private System.Windows.Forms.Button buttonSettings_A;
        private System.Windows.Forms.Button buttonEnable_A;
        private System.Windows.Forms.Button buttonDisable_A;
        private System.Windows.Forms.Button buttonMove_A;
        private System.Windows.Forms.Button buttonHalt_A;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer timer_A;
        private System.Windows.Forms.GroupBox groupBox3_B;
        private System.Windows.Forms.Label label7_B;
        private System.Windows.Forms.Label label8_B;
        private System.Windows.Forms.TextBox textBoxPositionActualValue_B;
        private System.Windows.Forms.Label label6_B;
        private System.Windows.Forms.Label label4_B;
        private System.Windows.Forms.TextBox textBoxPositionStart_B;
        private System.Windows.Forms.GroupBox groupBox2_B;
        private System.Windows.Forms.RadioButton radioButtonAbsoluteMove_B;
        private System.Windows.Forms.Button buttonHalt_B;
        private System.Windows.Forms.Button buttonMove_B;
        private System.Windows.Forms.RadioButton radioButtonRelativeMode_B;
        private System.Windows.Forms.Label label5_B;
        private System.Windows.Forms.Label label3_B;
        private System.Windows.Forms.TextBox textBoxTargetPosition_B;
        private System.Windows.Forms.GroupBox groupBox1_B;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.Button buttonDisable_B;
        private System.Windows.Forms.TextBox textBoxNodeId_B;
        private System.Windows.Forms.Button buttonEnable_B;
        private System.Windows.Forms.Label label1_B;
        private System.Windows.Forms.Button buttonSettings_B;
        private System.Windows.Forms.TextBox textBoxAOM_B;
        private System.Windows.Forms.Timer timer_B;
        private System.Windows.Forms.CheckBox checkBox_use_joy;
        private System.Windows.Forms.Label label_right_trigger;
        private System.Windows.Forms.Label label_left_trigger;
        private System.Windows.Forms.Label label_right_axis_y;
        private System.Windows.Forms.Label label_right_axis_x;
        private System.Windows.Forms.Label label_left_axis_y;
        private System.Windows.Forms.Label label_left_axis_x;
    }
}

