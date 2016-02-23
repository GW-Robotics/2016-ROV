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
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshGamepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbJoysticks = new System.Windows.Forms.GroupBox();
            this.gbButtons = new System.Windows.Forms.GroupBox();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.clbABXY = new System.Windows.Forms.CheckedListBox();
            this.clbSelectStart = new System.Windows.Forms.CheckedListBox();
            this.clbThumbs = new System.Windows.Forms.CheckedListBox();
            this.clbDPad = new System.Windows.Forms.CheckedListBox();
            this.clbShoulders = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1.SuspendLayout();
            this.gbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(12, 313);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(467, 78);
            this.txtOutput.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gamepadToolStripMenuItem});
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
            this.gamepadToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
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
            // gbJoysticks
            // 
            this.gbJoysticks.Location = new System.Drawing.Point(12, 27);
            this.gbJoysticks.Name = "gbJoysticks";
            this.gbJoysticks.Size = new System.Drawing.Size(392, 280);
            this.gbJoysticks.TabIndex = 2;
            this.gbJoysticks.TabStop = false;
            this.gbJoysticks.Text = "Joysticks";
            // 
            // gbButtons
            // 
            this.gbButtons.Controls.Add(this.clbShoulders);
            this.gbButtons.Controls.Add(this.clbDPad);
            this.gbButtons.Controls.Add(this.clbThumbs);
            this.gbButtons.Controls.Add(this.clbSelectStart);
            this.gbButtons.Controls.Add(this.clbABXY);
            this.gbButtons.Location = new System.Drawing.Point(410, 27);
            this.gbButtons.Name = "gbButtons";
            this.gbButtons.Size = new System.Drawing.Size(69, 280);
            this.gbButtons.TabIndex = 3;
            this.gbButtons.TabStop = false;
            this.gbButtons.Text = "Buttons";
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
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
            // clbSelectStart
            // 
            this.clbSelectStart.FormattingEnabled = true;
            this.clbSelectStart.Items.AddRange(new object[] {
            "Select",
            "Start"});
            this.clbSelectStart.Location = new System.Drawing.Point(6, 89);
            this.clbSelectStart.Name = "clbSelectStart";
            this.clbSelectStart.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.clbSelectStart.Size = new System.Drawing.Size(56, 34);
            this.clbSelectStart.TabIndex = 6;
            // 
            // clbThumbs
            // 
            this.clbThumbs.FormattingEnabled = true;
            this.clbThumbs.Items.AddRange(new object[] {
            "L3",
            "R3"});
            this.clbThumbs.Location = new System.Drawing.Point(6, 129);
            this.clbThumbs.Name = "clbThumbs";
            this.clbThumbs.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.clbThumbs.Size = new System.Drawing.Size(56, 34);
            this.clbThumbs.TabIndex = 7;
            // 
            // clbDPad
            // 
            this.clbDPad.FormattingEnabled = true;
            this.clbDPad.Items.AddRange(new object[] {
            "Up",
            "Down",
            "Left",
            "Right"});
            this.clbDPad.Location = new System.Drawing.Point(6, 169);
            this.clbDPad.Name = "clbDPad";
            this.clbDPad.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.clbDPad.Size = new System.Drawing.Size(56, 64);
            this.clbDPad.TabIndex = 8;
            // 
            // clbShoulders
            // 
            this.clbShoulders.FormattingEnabled = true;
            this.clbShoulders.Items.AddRange(new object[] {
            "LB",
            "RB"});
            this.clbShoulders.Location = new System.Drawing.Point(6, 239);
            this.clbShoulders.Name = "clbShoulders";
            this.clbShoulders.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.clbShoulders.Size = new System.Drawing.Size(56, 34);
            this.clbShoulders.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 400);
            this.Controls.Add(this.gbButtons);
            this.Controls.Add(this.gbJoysticks);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Gamepad Swagger Station";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbButtons.ResumeLayout(false);
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
    }
}

