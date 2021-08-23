namespace _4d_Interface
{
    partial class GuiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuiForm));
            this.baudRateBox = new System.Windows.Forms.ComboBox();
            this.beaudRateLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.title = new System.Windows.Forms.Label();
            this.mainToolStrip = new System.Windows.Forms.MenuStrip();
            this.supportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadPortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.setTempA = new System.Windows.Forms.NumericUpDown();
            this.setSpeedA = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.set_e1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.e1_temp = new System.Windows.Forms.Label();
            this.e1_speed = new System.Windows.Forms.Label();
            this.e2_speed = new System.Windows.Forms.Label();
            this.e2_temp = new System.Windows.Forms.Label();
            this.set_e2 = new System.Windows.Forms.Button();
            this.setSpeedB = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.setTempB = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fanA_button = new System.Windows.Forms.CheckBox();
            this.fanB_button = new System.Windows.Forms.CheckBox();
            this.activateA_radioButton = new System.Windows.Forms.RadioButton();
            this.activateB_radioButton = new System.Windows.Forms.RadioButton();
            this.setStepsB = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.setStepsA = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.reverseB = new System.Windows.Forms.CheckBox();
            this.reverseA = new System.Windows.Forms.CheckBox();
            this.mainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setTempA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setSpeedA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setSpeedB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setTempB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setStepsB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setStepsA)).BeginInit();
            this.SuspendLayout();
            // 
            // baudRateBox
            // 
            this.baudRateBox.BackColor = System.Drawing.Color.Yellow;
            this.baudRateBox.ForeColor = System.Drawing.Color.Red;
            this.baudRateBox.FormattingEnabled = true;
            this.baudRateBox.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "256000"});
            this.baudRateBox.Location = new System.Drawing.Point(130, 192);
            this.baudRateBox.Name = "baudRateBox";
            this.baudRateBox.Size = new System.Drawing.Size(111, 21);
            this.baudRateBox.TabIndex = 20;
            // 
            // beaudRateLabel
            // 
            this.beaudRateLabel.AutoSize = true;
            this.beaudRateLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beaudRateLabel.ForeColor = System.Drawing.Color.Red;
            this.beaudRateLabel.Location = new System.Drawing.Point(127, 174);
            this.beaudRateLabel.Name = "beaudRateLabel";
            this.beaudRateLabel.Size = new System.Drawing.Size(77, 14);
            this.beaudRateLabel.TabIndex = 19;
            this.beaudRateLabel.Text = "Baud Rate:";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLabel.ForeColor = System.Drawing.Color.Red;
            this.portLabel.Location = new System.Drawing.Point(8, 174);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(42, 14);
            this.portLabel.TabIndex = 18;
            this.portLabel.Text = "Port:";
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.Color.Black;
            this.connectBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.connectBtn.FlatAppearance.BorderSize = 0;
            this.connectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.connectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.connectBtn.ForeColor = System.Drawing.Color.Yellow;
            this.connectBtn.Location = new System.Drawing.Point(247, 191);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 21);
            this.connectBtn.TabIndex = 17;
            this.connectBtn.Text = "connect";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // portComboBox
            // 
            this.portComboBox.BackColor = System.Drawing.Color.Yellow;
            this.portComboBox.ForeColor = System.Drawing.Color.Red;
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(11, 192);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(113, 21);
            this.portComboBox.TabIndex = 16;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Bold);
            this.title.ForeColor = System.Drawing.Color.Red;
            this.title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.title.Location = new System.Drawing.Point(-2, 29);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(336, 130);
            this.title.TabIndex = 28;
            this.title.Text = resources.GetString("title.Text");
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.BackColor = System.Drawing.Color.Red;
            this.mainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportToolStripMenuItem1});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(334, 24);
            this.mainToolStrip.TabIndex = 30;
            this.mainToolStrip.Text = "menuStrip2";
            // 
            // supportToolStripMenuItem1
            // 
            this.supportToolStripMenuItem1.CheckOnClick = true;
            this.supportToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toggleSoundToolStripMenuItem,
            this.reloadPortsToolStripMenuItem});
            this.supportToolStripMenuItem1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supportToolStripMenuItem1.ForeColor = System.Drawing.Color.Yellow;
            this.supportToolStripMenuItem1.Name = "supportToolStripMenuItem1";
            this.supportToolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.supportToolStripMenuItem1.Text = "Support";
            // 
            // toggleSoundToolStripMenuItem
            // 
            this.toggleSoundToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.toggleSoundToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.toggleSoundToolStripMenuItem.Name = "toggleSoundToolStripMenuItem";
            this.toggleSoundToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.toggleSoundToolStripMenuItem.Text = "Toggle Sound";
            this.toggleSoundToolStripMenuItem.Click += new System.EventHandler(this.toggleSoundToolStripMenuItem_Click);
            // 
            // reloadPortsToolStripMenuItem
            // 
            this.reloadPortsToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.reloadPortsToolStripMenuItem.ForeColor = System.Drawing.Color.Yellow;
            this.reloadPortsToolStripMenuItem.Name = "reloadPortsToolStripMenuItem";
            this.reloadPortsToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.reloadPortsToolStripMenuItem.Text = "Reload Ports";
            this.reloadPortsToolStripMenuItem.Click += new System.EventHandler(this.reloadPortsToolStripMenuItem_Click);
            // 
            // consoleBox
            // 
            this.consoleBox.BackColor = System.Drawing.Color.Black;
            this.consoleBox.ForeColor = System.Drawing.Color.Yellow;
            this.consoleBox.Location = new System.Drawing.Point(0, 499);
            this.consoleBox.Multiline = true;
            this.consoleBox.Name = "consoleBox";
            this.consoleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleBox.Size = new System.Drawing.Size(334, 164);
            this.consoleBox.TabIndex = 31;
            this.consoleBox.Text = "4D: Initializing software...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 32;
            this.label1.Text = "Temp:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(11, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 1);
            this.label6.TabIndex = 33;
            // 
            // setTempA
            // 
            this.setTempA.BackColor = System.Drawing.Color.Yellow;
            this.setTempA.ForeColor = System.Drawing.Color.Red;
            this.setTempA.Location = new System.Drawing.Point(12, 289);
            this.setTempA.Maximum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.setTempA.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.setTempA.Name = "setTempA";
            this.setTempA.Size = new System.Drawing.Size(139, 20);
            this.setTempA.TabIndex = 34;
            this.setTempA.Value = new decimal(new int[] {
            2500,
            0,
            0,
            131072});
            // 
            // setSpeedA
            // 
            this.setSpeedA.BackColor = System.Drawing.Color.Yellow;
            this.setSpeedA.ForeColor = System.Drawing.Color.Red;
            this.setSpeedA.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.setSpeedA.Location = new System.Drawing.Point(12, 334);
            this.setSpeedA.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.setSpeedA.Name = "setSpeedA";
            this.setSpeedA.Size = new System.Drawing.Size(139, 20);
            this.setSpeedA.TabIndex = 36;
            this.setSpeedA.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(10, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 35;
            this.label2.Text = "Speed:";
            // 
            // set_e1
            // 
            this.set_e1.BackColor = System.Drawing.Color.Black;
            this.set_e1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.set_e1.FlatAppearance.BorderSize = 0;
            this.set_e1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.set_e1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.set_e1.ForeColor = System.Drawing.Color.Yellow;
            this.set_e1.Location = new System.Drawing.Point(11, 444);
            this.set_e1.Name = "set_e1";
            this.set_e1.Size = new System.Drawing.Size(142, 21);
            this.set_e1.TabIndex = 37;
            this.set_e1.Text = "set";
            this.set_e1.UseVisualStyleBackColor = false;
            this.set_e1.Click += new System.EventHandler(this.set_e1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(166, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1, 230);
            this.label3.TabIndex = 38;
            // 
            // e1_temp
            // 
            this.e1_temp.AutoSize = true;
            this.e1_temp.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e1_temp.ForeColor = System.Drawing.Color.Red;
            this.e1_temp.Location = new System.Drawing.Point(88, 272);
            this.e1_temp.Name = "e1_temp";
            this.e1_temp.Size = new System.Drawing.Size(42, 14);
            this.e1_temp.TabIndex = 40;
            this.e1_temp.Text = "00.00";
            this.e1_temp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // e1_speed
            // 
            this.e1_speed.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e1_speed.ForeColor = System.Drawing.Color.Red;
            this.e1_speed.Location = new System.Drawing.Point(88, 317);
            this.e1_speed.Name = "e1_speed";
            this.e1_speed.Size = new System.Drawing.Size(63, 14);
            this.e1_speed.TabIndex = 41;
            this.e1_speed.Text = "0 Hz";
            this.e1_speed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // e2_speed
            // 
            this.e2_speed.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e2_speed.ForeColor = System.Drawing.Color.Red;
            this.e2_speed.Location = new System.Drawing.Point(257, 317);
            this.e2_speed.Name = "e2_speed";
            this.e2_speed.Size = new System.Drawing.Size(63, 14);
            this.e2_speed.TabIndex = 49;
            this.e2_speed.Text = "0 Hz";
            this.e2_speed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // e2_temp
            // 
            this.e2_temp.AutoSize = true;
            this.e2_temp.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e2_temp.ForeColor = System.Drawing.Color.Red;
            this.e2_temp.Location = new System.Drawing.Point(257, 272);
            this.e2_temp.Name = "e2_temp";
            this.e2_temp.Size = new System.Drawing.Size(42, 14);
            this.e2_temp.TabIndex = 48;
            this.e2_temp.Text = "00.00";
            this.e2_temp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // set_e2
            // 
            this.set_e2.BackColor = System.Drawing.Color.Black;
            this.set_e2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.set_e2.FlatAppearance.BorderSize = 0;
            this.set_e2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.set_e2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.set_e2.ForeColor = System.Drawing.Color.Yellow;
            this.set_e2.Location = new System.Drawing.Point(179, 444);
            this.set_e2.Name = "set_e2";
            this.set_e2.Size = new System.Drawing.Size(142, 21);
            this.set_e2.TabIndex = 47;
            this.set_e2.Text = "set";
            this.set_e2.UseVisualStyleBackColor = false;
            this.set_e2.Click += new System.EventHandler(this.set_e2_Click);
            // 
            // setSpeedB
            // 
            this.setSpeedB.BackColor = System.Drawing.Color.Yellow;
            this.setSpeedB.ForeColor = System.Drawing.Color.Red;
            this.setSpeedB.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.setSpeedB.Location = new System.Drawing.Point(181, 334);
            this.setSpeedB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.setSpeedB.Name = "setSpeedB";
            this.setSpeedB.Size = new System.Drawing.Size(139, 20);
            this.setSpeedB.TabIndex = 46;
            this.setSpeedB.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(179, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 14);
            this.label11.TabIndex = 45;
            this.label11.Text = "Speed:";
            // 
            // setTempB
            // 
            this.setTempB.BackColor = System.Drawing.Color.Yellow;
            this.setTempB.ForeColor = System.Drawing.Color.Red;
            this.setTempB.Location = new System.Drawing.Point(181, 289);
            this.setTempB.Maximum = new decimal(new int[] {
            350,
            0,
            0,
            0});
            this.setTempB.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.setTempB.Name = "setTempB";
            this.setTempB.Size = new System.Drawing.Size(139, 20);
            this.setTempB.TabIndex = 44;
            this.setTempB.Value = new decimal(new int[] {
            2500,
            0,
            0,
            131072});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(178, 272);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 14);
            this.label12.TabIndex = 43;
            this.label12.Text = "Temp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(299, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 14);
            this.label5.TabIndex = 50;
            this.label5.Text = "°C";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(130, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 14);
            this.label10.TabIndex = 51;
            this.label10.Text = "°C";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // fanA_button
            // 
            this.fanA_button.AutoSize = true;
            this.fanA_button.Enabled = false;
            this.fanA_button.ForeColor = System.Drawing.Color.Red;
            this.fanA_button.Location = new System.Drawing.Point(13, 418);
            this.fanA_button.Name = "fanA_button";
            this.fanA_button.Size = new System.Drawing.Size(44, 17);
            this.fanA_button.TabIndex = 55;
            this.fanA_button.Text = "Fan";
            this.fanA_button.UseVisualStyleBackColor = true;
            this.fanA_button.CheckedChanged += new System.EventHandler(this.fanA_button_CheckedChanged_1);
            // 
            // fanB_button
            // 
            this.fanB_button.AutoSize = true;
            this.fanB_button.Enabled = false;
            this.fanB_button.ForeColor = System.Drawing.Color.Red;
            this.fanB_button.Location = new System.Drawing.Point(182, 418);
            this.fanB_button.Name = "fanB_button";
            this.fanB_button.Size = new System.Drawing.Size(44, 17);
            this.fanB_button.TabIndex = 56;
            this.fanB_button.Text = "Fan";
            this.fanB_button.UseVisualStyleBackColor = true;
            this.fanB_button.CheckedChanged += new System.EventHandler(this.fanB_button_CheckedChanged_1);
            // 
            // activateA_radioButton
            // 
            this.activateA_radioButton.AutoSize = true;
            this.activateA_radioButton.Enabled = false;
            this.activateA_radioButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateA_radioButton.ForeColor = System.Drawing.Color.Red;
            this.activateA_radioButton.Location = new System.Drawing.Point(60, 240);
            this.activateA_radioButton.Name = "activateA_radioButton";
            this.activateA_radioButton.Size = new System.Drawing.Size(45, 23);
            this.activateA_radioButton.TabIndex = 59;
            this.activateA_radioButton.TabStop = true;
            this.activateA_radioButton.Text = "E1";
            this.activateA_radioButton.UseVisualStyleBackColor = true;
            this.activateA_radioButton.CheckedChanged += new System.EventHandler(this.activateA_radioButton_CheckedChanged);
            // 
            // activateB_radioButton
            // 
            this.activateB_radioButton.AutoSize = true;
            this.activateB_radioButton.Enabled = false;
            this.activateB_radioButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateB_radioButton.ForeColor = System.Drawing.Color.Red;
            this.activateB_radioButton.Location = new System.Drawing.Point(226, 240);
            this.activateB_radioButton.Name = "activateB_radioButton";
            this.activateB_radioButton.Size = new System.Drawing.Size(45, 23);
            this.activateB_radioButton.TabIndex = 60;
            this.activateB_radioButton.TabStop = true;
            this.activateB_radioButton.Text = "E2";
            this.activateB_radioButton.UseVisualStyleBackColor = true;
            // 
            // setStepsB
            // 
            this.setStepsB.BackColor = System.Drawing.Color.Yellow;
            this.setStepsB.ForeColor = System.Drawing.Color.Red;
            this.setStepsB.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.setStepsB.Location = new System.Drawing.Point(181, 380);
            this.setStepsB.Maximum = new decimal(new int[] {
            64000,
            0,
            0,
            0});
            this.setStepsB.Name = "setStepsB";
            this.setStepsB.Size = new System.Drawing.Size(139, 20);
            this.setStepsB.TabIndex = 62;
            this.setStepsB.Value = new decimal(new int[] {
            6400,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(179, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 61;
            this.label4.Text = "Steps:";
            // 
            // setStepsA
            // 
            this.setStepsA.BackColor = System.Drawing.Color.Yellow;
            this.setStepsA.ForeColor = System.Drawing.Color.Red;
            this.setStepsA.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.setStepsA.Location = new System.Drawing.Point(12, 380);
            this.setStepsA.Maximum = new decimal(new int[] {
            64000,
            0,
            0,
            0});
            this.setStepsA.Name = "setStepsA";
            this.setStepsA.Size = new System.Drawing.Size(139, 20);
            this.setStepsA.TabIndex = 64;
            this.setStepsA.Value = new decimal(new int[] {
            6400,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(10, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 14);
            this.label7.TabIndex = 63;
            this.label7.Text = "Steps:";
            // 
            // reverseB
            // 
            this.reverseB.AutoSize = true;
            this.reverseB.ForeColor = System.Drawing.Color.Red;
            this.reverseB.Location = new System.Drawing.Point(270, 418);
            this.reverseB.Name = "reverseB";
            this.reverseB.Size = new System.Drawing.Size(50, 17);
            this.reverseB.TabIndex = 65;
            this.reverseB.Text = "Rev.";
            this.reverseB.UseVisualStyleBackColor = true;
            this.reverseB.CheckedChanged += new System.EventHandler(this.reverseB_CheckedChanged);
            // 
            // reverseA
            // 
            this.reverseA.AutoSize = true;
            this.reverseA.ForeColor = System.Drawing.Color.Red;
            this.reverseA.Location = new System.Drawing.Point(103, 418);
            this.reverseA.Name = "reverseA";
            this.reverseA.Size = new System.Drawing.Size(50, 17);
            this.reverseA.TabIndex = 66;
            this.reverseA.Text = "Rev.";
            this.reverseA.UseVisualStyleBackColor = true;
            this.reverseA.CheckedChanged += new System.EventHandler(this.reverseA_CheckedChanged);
            // 
            // GuiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(334, 662);
            this.Controls.Add(this.reverseA);
            this.Controls.Add(this.reverseB);
            this.Controls.Add(this.setStepsA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.setStepsB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.activateB_radioButton);
            this.Controls.Add(this.activateA_radioButton);
            this.Controls.Add(this.fanB_button);
            this.Controls.Add(this.fanA_button);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.e2_speed);
            this.Controls.Add(this.e2_temp);
            this.Controls.Add(this.set_e2);
            this.Controls.Add(this.setSpeedB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.setTempB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.e1_speed);
            this.Controls.Add(this.e1_temp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.set_e1);
            this.Controls.Add(this.setSpeedA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.setTempA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consoleBox);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.title);
            this.Controls.Add(this.baudRateBox);
            this.Controls.Add(this.beaudRateLabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.portComboBox);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuiForm";
            this.Text = "4D Cell";
            this.Load += new System.EventHandler(this.GuiForm_Load);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.setTempA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setSpeedA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setSpeedB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setTempB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setStepsB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setStepsA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox baudRateBox;
        private System.Windows.Forms.Label beaudRateLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toggleSoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadPortsToolStripMenuItem;
        private System.Windows.Forms.TextBox consoleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown setTempA;
        private System.Windows.Forms.NumericUpDown setSpeedA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button set_e1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label e1_temp;
        private System.Windows.Forms.Label e1_speed;
        private System.Windows.Forms.Label e2_speed;
        private System.Windows.Forms.Label e2_temp;
        private System.Windows.Forms.Button set_e2;
        private System.Windows.Forms.NumericUpDown setSpeedB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown setTempB;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.MenuStrip mainToolStrip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox fanA_button;
        private System.Windows.Forms.CheckBox fanB_button;
        private System.Windows.Forms.RadioButton activateA_radioButton;
        private System.Windows.Forms.RadioButton activateB_radioButton;
        private System.Windows.Forms.NumericUpDown setStepsB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown setStepsA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox reverseB;
        private System.Windows.Forms.CheckBox reverseA;
    }
}

