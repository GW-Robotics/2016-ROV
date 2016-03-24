namespace Gamepad_Swagger_Station
{
    partial class frmMain
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
            this.arduinoSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joystickInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshGamepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.menuBoxPort = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.changeCommsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tCPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbJoysticks = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pbRightT = new System.Windows.Forms.ProgressBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pbLeftT = new System.Windows.Forms.ProgressBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pbRightY = new System.Windows.Forms.ProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pbRightX = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLeftY = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAxis = new System.Windows.Forms.Label();
            this.pbLeftX = new System.Windows.Forms.ProgressBar();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.clbShoulders = new System.Windows.Forms.CheckedListBox();
            this.clbDPad = new System.Windows.Forms.CheckedListBox();
            this.clbThumbs = new System.Windows.Forms.CheckedListBox();
            this.clbSelectStart = new System.Windows.Forms.CheckedListBox();
            this.clbABXY = new System.Windows.Forms.CheckedListBox();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbJoysticks.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbButtons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 258);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(364, 66);
            this.txtOutput.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(612, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonInputToolStripMenuItem,
            this.joystickInputToolStripMenuItem,
            this.toolStripSeparator3});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // buttonInputToolStripMenuItem
            // 
            this.buttonInputToolStripMenuItem.Name = "buttonInputToolStripMenuItem";
            this.buttonInputToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.buttonInputToolStripMenuItem.Text = "Button Input";
            this.buttonInputToolStripMenuItem.Click += new System.EventHandler(this.buttonInputToolStripMenuItem_Click);
            // 
            // joystickInputToolStripMenuItem
            // 
            this.joystickInputToolStripMenuItem.Name = "joystickInputToolStripMenuItem";
            this.joystickInputToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.joystickInputToolStripMenuItem.Text = "Joystick Input";
            this.joystickInputToolStripMenuItem.Click += new System.EventHandler(this.joystickInputToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(143, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gamepadToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.menuBoxPort,
            this.toolStripSeparator2,
            this.changeCommsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // gamepadToolStripMenuItem
            // 
            this.gamepadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlsToolStripMenuItem,
            this.refreshGamepadToolStripMenuItem});
            this.gamepadToolStripMenuItem.Name = "gamepadToolStripMenuItem";
            this.gamepadToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.gamepadToolStripMenuItem.Text = "Gamepad";
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.controlsToolStripMenuItem.Text = "Controls";
            // 
            // refreshGamepadToolStripMenuItem
            // 
            this.refreshGamepadToolStripMenuItem.Name = "refreshGamepadToolStripMenuItem";
            this.refreshGamepadToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.refreshGamepadToolStripMenuItem.Text = "Refresh Gamepad";
            this.refreshGamepadToolStripMenuItem.Click += new System.EventHandler(this.refreshGamepadToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "Port";
            // 
            // menuBoxPort
            // 
            this.menuBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.menuBoxPort.Items.AddRange(new object[] {
            "COM0",
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.menuBoxPort.Name = "menuBoxPort";
            this.menuBoxPort.Size = new System.Drawing.Size(121, 23);
            this.menuBoxPort.SelectedIndexChanged += new System.EventHandler(this.menuBoxPort_SelectedIndexChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // changeCommsToolStripMenuItem
            // 
            this.changeCommsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialToolStripMenuItem,
            this.tCPToolStripMenuItem});
            this.changeCommsToolStripMenuItem.Name = "changeCommsToolStripMenuItem";
            this.changeCommsToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.changeCommsToolStripMenuItem.Text = "Change Comms";
            // 
            // serialToolStripMenuItem
            // 
            this.serialToolStripMenuItem.Name = "serialToolStripMenuItem";
            this.serialToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.serialToolStripMenuItem.Text = "Serial";
            this.serialToolStripMenuItem.Click += new System.EventHandler(this.serialToolStripMenuItem_Click);
            // 
            // tCPToolStripMenuItem
            // 
            this.tCPToolStripMenuItem.Name = "tCPToolStripMenuItem";
            this.tCPToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.tCPToolStripMenuItem.Text = "TCP";
            this.tCPToolStripMenuItem.Click += new System.EventHandler(this.tCPToolStripMenuItem_Click);
            // 
            // gbJoysticks
            // 
            this.gbJoysticks.Controls.Add(this.panel6);
            this.gbJoysticks.Controls.Add(this.panel5);
            this.gbJoysticks.Controls.Add(this.panel4);
            this.gbJoysticks.Controls.Add(this.panel3);
            this.gbJoysticks.Controls.Add(this.panel2);
            this.gbJoysticks.Controls.Add(this.panel1);
            this.gbJoysticks.Location = new System.Drawing.Point(12, 27);
            this.gbJoysticks.Name = "gbJoysticks";
            this.gbJoysticks.Size = new System.Drawing.Size(364, 130);
            this.gbJoysticks.TabIndex = 2;
            this.gbJoysticks.TabStop = false;
            this.gbJoysticks.Text = "Joysticks";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.pbRightT);
            this.panel6.Location = new System.Drawing.Point(185, 91);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(173, 30);
            this.panel6.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Right T";
            // 
            // pbRightT
            // 
            this.pbRightT.Location = new System.Drawing.Point(51, 3);
            this.pbRightT.Maximum = 255;
            this.pbRightT.Name = "pbRightT";
            this.pbRightT.Size = new System.Drawing.Size(118, 23);
            this.pbRightT.Step = 1;
            this.pbRightT.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbRightT.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.pbLeftT);
            this.panel5.Location = new System.Drawing.Point(6, 91);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(173, 30);
            this.panel5.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Left T";
            // 
            // pbLeftT
            // 
            this.pbLeftT.Location = new System.Drawing.Point(51, 3);
            this.pbLeftT.Maximum = 255;
            this.pbLeftT.Name = "pbLeftT";
            this.pbLeftT.Size = new System.Drawing.Size(118, 23);
            this.pbLeftT.Step = 1;
            this.pbLeftT.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbLeftT.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pbRightY);
            this.panel4.Location = new System.Drawing.Point(185, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(173, 30);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Right Y";
            // 
            // pbRightY
            // 
            this.pbRightY.Location = new System.Drawing.Point(51, 3);
            this.pbRightY.Maximum = 65536;
            this.pbRightY.Name = "pbRightY";
            this.pbRightY.Size = new System.Drawing.Size(118, 23);
            this.pbRightY.Step = 1;
            this.pbRightY.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbRightY.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.pbRightX);
            this.panel3.Location = new System.Drawing.Point(6, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(173, 30);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Right X";
            // 
            // pbRightX
            // 
            this.pbRightX.Location = new System.Drawing.Point(51, 3);
            this.pbRightX.Maximum = 65536;
            this.pbRightX.Name = "pbRightX";
            this.pbRightX.Size = new System.Drawing.Size(118, 23);
            this.pbRightX.Step = 1;
            this.pbRightX.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbRightX.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pbLeftY);
            this.panel2.Location = new System.Drawing.Point(185, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 30);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Left Y";
            // 
            // pbLeftY
            // 
            this.pbLeftY.Location = new System.Drawing.Point(51, 3);
            this.pbLeftY.Maximum = 65536;
            this.pbLeftY.Name = "pbLeftY";
            this.pbLeftY.Size = new System.Drawing.Size(118, 23);
            this.pbLeftY.Step = 1;
            this.pbLeftY.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbLeftY.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAxis);
            this.panel1.Controls.Add(this.pbLeftX);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 30);
            this.panel1.TabIndex = 1;
            // 
            // lblAxis
            // 
            this.lblAxis.AutoSize = true;
            this.lblAxis.Location = new System.Drawing.Point(3, 9);
            this.lblAxis.Name = "lblAxis";
            this.lblAxis.Size = new System.Drawing.Size(35, 13);
            this.lblAxis.TabIndex = 1;
            this.lblAxis.Text = "Left X";
            // 
            // pbLeftX
            // 
            this.pbLeftX.Location = new System.Drawing.Point(51, 3);
            this.pbLeftX.Maximum = 65536;
            this.pbLeftX.Name = "pbLeftX";
            this.pbLeftX.Size = new System.Drawing.Size(118, 23);
            this.pbLeftX.Step = 1;
            this.pbLeftX.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbLeftX.TabIndex = 0;
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.clbShoulders);
            this.gbButtons.Controls.Add(this.clbDPad);
            this.gbButtons.Controls.Add(this.clbThumbs);
            this.gbButtons.Controls.Add(this.clbSelectStart);
            this.gbButtons.Controls.Add(this.clbABXY);
            this.gbButtons.Location = new System.Drawing.Point(12, 163);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(364, 89);
            this.gbButtons.TabIndex = 3;
            this.gbButtons.TabStop = false;
            this.gbButtons.Text = "Buttons";
            // 
            // clbShoulders
            // 
            this.clbShoulders.FormattingEnabled = true;
            this.clbShoulders.Items.AddRange(new object[] {
            "LB",
            "RB"});
            this.clbShoulders.Location = new System.Drawing.Point(254, 19);
            this.clbShoulders.Name = "clbShoulders";
            this.clbShoulders.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.clbShoulders.Size = new System.Drawing.Size(56, 34);
            this.clbShoulders.TabIndex = 9;
            // 
            // clbDPad
            // 
            this.clbDPad.FormattingEnabled = true;
            this.clbDPad.Items.AddRange(new object[] {
            "Up",
            "Down",
            "Left",
            "Right"});
            this.clbDPad.Location = new System.Drawing.Point(68, 19);
            this.clbDPad.Name = "clbDPad";
            this.clbDPad.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.clbDPad.Size = new System.Drawing.Size(56, 64);
            this.clbDPad.TabIndex = 8;
            // 
            // clbThumbs
            // 
            this.clbThumbs.FormattingEnabled = true;
            this.clbThumbs.Items.AddRange(new object[] {
            "L3",
            "R3"});
            this.clbThumbs.Location = new System.Drawing.Point(130, 19);
            this.clbThumbs.Name = "clbThumbs";
            this.clbThumbs.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.clbThumbs.Size = new System.Drawing.Size(56, 34);
            this.clbThumbs.TabIndex = 7;
            // 
            // clbSelectStart
            // 
            this.clbSelectStart.FormattingEnabled = true;
            this.clbSelectStart.Items.AddRange(new object[] {
            "Select",
            "Start"});
            this.clbSelectStart.Location = new System.Drawing.Point(192, 19);
            this.clbSelectStart.Name = "clbSelectStart";
            this.clbSelectStart.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.clbSelectStart.Size = new System.Drawing.Size(56, 34);
            this.clbSelectStart.TabIndex = 6;
            // 
            // clbABXY
            // 
            this.clbABXY.FormattingEnabled = true;
            this.clbABXY.Items.AddRange(new object[] {
            "A",
            "B",
            "X",
            "Y"});
            this.clbABXY.Location = new System.Drawing.Point(6, 19);
            this.clbABXY.Name = "clbABXY";
            this.clbABXY.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.clbABXY.Size = new System.Drawing.Size(56, 64);
            this.clbABXY.TabIndex = 5;
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(612, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Location = new System.Drawing.Point(382, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 92);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WiFi Communications Settings";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtIP);
            this.panel7.Controls.Add(this.lblIP);
            this.panel7.Location = new System.Drawing.Point(6, 19);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(206, 30);
            this.panel7.TabIndex = 0;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(3, 9);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(17, 13);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(35, 6);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(168, 20);
            this.txtIP.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtPort);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(6, 55);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(206, 30);
            this.panel8.TabIndex = 2;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(35, 6);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(168, 20);
            this.txtPort.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Port";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gbButtons);
            this.Controls.Add(this.gbJoysticks);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Gamepad Swagger Station";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbJoysticks.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbButtons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort arduinoSerialPort;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.ToolStripMenuItem refreshGamepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox gbJoysticks;
        private System.Windows.Forms.GroupBox gbButtons;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.CheckedListBox clbShoulders;
        private System.Windows.Forms.CheckedListBox clbDPad;
        private System.Windows.Forms.CheckedListBox clbThumbs;
        private System.Windows.Forms.CheckedListBox clbSelectStart;
        private System.Windows.Forms.CheckedListBox clbABXY;
        private System.Windows.Forms.ToolStripComboBox menuBoxPort;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ProgressBar pbLeftX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAxis;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbRightT;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pbLeftT;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pbRightY;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pbRightX;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbLeftY;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonInputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joystickInputToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem changeCommsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tCPToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblIP;
    }
}

