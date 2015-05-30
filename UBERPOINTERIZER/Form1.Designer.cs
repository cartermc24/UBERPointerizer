namespace UBERPOINTERIZER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.waitPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPB = new System.Windows.Forms.ProgressBar();
            this.CONTROLLABEL = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.md5BOX = new System.Windows.Forms.TextBox();
            this.uberidBOX = new System.Windows.Forms.TextBox();
            this.adBOX = new System.Windows.Forms.TextBox();
            this.tokenBOX = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.latBox = new System.Windows.Forms.TextBox();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.loginErrorLabel = new System.Windows.Forms.Label();
            this.connectBOX = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lonBox = new System.Windows.Forms.TextBox();
            this.otherLOCATIONBOX = new System.Windows.Forms.RadioButton();
            this.nycBOX = new System.Windows.Forms.RadioButton();
            this.provBOX = new System.Windows.Forms.RadioButton();
            this.bostonBOX = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mapPausedLabel = new System.Windows.Forms.Label();
            this.browserLoad = new System.Windows.Forms.PictureBox();
            this.tripAnaPanel = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.timeThresBox = new System.Windows.Forms.TextBox();
            this.distThresBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mapSelector = new System.Windows.Forms.TrackBar();
            this.incomStatusLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.carBox = new System.Windows.Forms.ListBox();
            this.logoutButton = new System.Windows.Forms.Button();
            this.runningTimer = new System.Windows.Forms.Timer(this.components);
            this.fileReaderUpdater = new System.Windows.Forms.Timer(this.components);
            this.onlineUpdater = new System.Windows.Forms.Timer(this.components);
            this.tripAnaTimer = new System.Windows.Forms.Timer(this.components);
            this.waitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.loginPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.browserLoad)).BeginInit();
            this.tripAnaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // waitPanel
            // 
            this.waitPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.waitPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.waitPanel.Controls.Add(this.label2);
            this.waitPanel.Controls.Add(this.label1);
            this.waitPanel.Controls.Add(this.pictureBox1);
            this.waitPanel.Location = new System.Drawing.Point(312, 139);
            this.waitPanel.Name = "waitPanel";
            this.waitPanel.Size = new System.Drawing.Size(190, 158);
            this.waitPanel.TabIndex = 0;
            this.waitPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CONNECTING TO UBER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "PLEASE WAIT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainPB
            // 
            this.mainPB.Location = new System.Drawing.Point(-41, 40);
            this.mainPB.Name = "mainPB";
            this.mainPB.Size = new System.Drawing.Size(1380, 10);
            this.mainPB.TabIndex = 1;
            // 
            // CONTROLLABEL
            // 
            this.CONTROLLABEL.AutoSize = true;
            this.CONTROLLABEL.BackColor = System.Drawing.Color.Transparent;
            this.CONTROLLABEL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CONTROLLABEL.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.CONTROLLABEL.Location = new System.Drawing.Point(2, 5);
            this.CONTROLLABEL.Name = "CONTROLLABEL";
            this.CONTROLLABEL.Size = new System.Drawing.Size(111, 32);
            this.CONTROLLABEL.TabIndex = 2;
            this.CONTROLLABEL.Text = "WAITING";
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPanel.Controls.Add(this.label21);
            this.loginPanel.Controls.Add(this.label19);
            this.loginPanel.Controls.Add(this.label18);
            this.loginPanel.Controls.Add(this.label4);
            this.loginPanel.Controls.Add(this.md5BOX);
            this.loginPanel.Controls.Add(this.uberidBOX);
            this.loginPanel.Controls.Add(this.adBOX);
            this.loginPanel.Controls.Add(this.tokenBOX);
            this.loginPanel.Controls.Add(this.label17);
            this.loginPanel.Controls.Add(this.label16);
            this.loginPanel.Controls.Add(this.latBox);
            this.loginPanel.Controls.Add(this.loadFileButton);
            this.loginPanel.Controls.Add(this.loginErrorLabel);
            this.loginPanel.Controls.Add(this.connectBOX);
            this.loginPanel.Controls.Add(this.label7);
            this.loginPanel.Controls.Add(this.lonBox);
            this.loginPanel.Controls.Add(this.otherLOCATIONBOX);
            this.loginPanel.Controls.Add(this.nycBOX);
            this.loginPanel.Controls.Add(this.provBOX);
            this.loginPanel.Controls.Add(this.bostonBOX);
            this.loginPanel.Controls.Add(this.label3);
            this.loginPanel.Controls.Add(this.label22);
            this.loginPanel.Location = new System.Drawing.Point(540, 172);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(373, 387);
            this.loginPanel.TabIndex = 3;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(24, 120);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 17);
            this.label21.TabIndex = 30;
            this.label21.Text = "LocalFileMD5";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 95);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 17);
            this.label19.TabIndex = 28;
            this.label19.Text = "UBER ID";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(24, 69);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 17);
            this.label18.TabIndex = 27;
            this.label18.Text = "AdvertisingID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Token";
            // 
            // md5BOX
            // 
            this.md5BOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.md5BOX.Location = new System.Drawing.Point(113, 117);
            this.md5BOX.Name = "md5BOX";
            this.md5BOX.Size = new System.Drawing.Size(243, 25);
            this.md5BOX.TabIndex = 24;
            // 
            // uberidBOX
            // 
            this.uberidBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uberidBOX.Location = new System.Drawing.Point(113, 91);
            this.uberidBOX.Name = "uberidBOX";
            this.uberidBOX.Size = new System.Drawing.Size(243, 25);
            this.uberidBOX.TabIndex = 22;
            // 
            // adBOX
            // 
            this.adBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adBOX.Location = new System.Drawing.Point(113, 65);
            this.adBOX.Name = "adBOX";
            this.adBOX.Size = new System.Drawing.Size(243, 25);
            this.adBOX.TabIndex = 21;
            // 
            // tokenBOX
            // 
            this.tokenBOX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tokenBOX.Location = new System.Drawing.Point(113, 39);
            this.tokenBOX.Name = "tokenBOX";
            this.tokenBOX.Size = new System.Drawing.Size(243, 25);
            this.tokenBOX.TabIndex = 19;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(119, 281);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 17);
            this.label17.TabIndex = 18;
            this.label17.Text = "Longitude";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(128, 251);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 17);
            this.label16.TabIndex = 17;
            this.label16.Text = "Latitude";
            // 
            // latBox
            // 
            this.latBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.latBox.Location = new System.Drawing.Point(187, 248);
            this.latBox.Name = "latBox";
            this.latBox.Size = new System.Drawing.Size(94, 25);
            this.latBox.TabIndex = 16;
            this.latBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // loadFileButton
            // 
            this.loadFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadFileButton.Location = new System.Drawing.Point(206, 311);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(103, 45);
            this.loadFileButton.TabIndex = 15;
            this.loadFileButton.Text = "LOAD LOCAL FILES";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // loginErrorLabel
            // 
            this.loginErrorLabel.AutoSize = true;
            this.loginErrorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.loginErrorLabel.Location = new System.Drawing.Point(78, 365);
            this.loginErrorLabel.Name = "loginErrorLabel";
            this.loginErrorLabel.Size = new System.Drawing.Size(248, 17);
            this.loginErrorLabel.TabIndex = 14;
            this.loginErrorLabel.Text = "One or more fields are blank or invalid";
            this.loginErrorLabel.Visible = false;
            // 
            // connectBOX
            // 
            this.connectBOX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectBOX.Location = new System.Drawing.Point(94, 311);
            this.connectBOX.Name = "connectBOX";
            this.connectBOX.Size = new System.Drawing.Size(103, 45);
            this.connectBOX.TabIndex = 13;
            this.connectBOX.Text = "CONNECT";
            this.connectBOX.UseVisualStyleBackColor = true;
            this.connectBOX.Click += new System.EventHandler(this.connectBOX_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "LOCATION:";
            // 
            // lonBox
            // 
            this.lonBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lonBox.Location = new System.Drawing.Point(187, 279);
            this.lonBox.Name = "lonBox";
            this.lonBox.Size = new System.Drawing.Size(94, 25);
            this.lonBox.TabIndex = 11;
            this.lonBox.TextChanged += new System.EventHandler(this.latBox_TextChanged);
            // 
            // otherLOCATIONBOX
            // 
            this.otherLOCATIONBOX.AutoSize = true;
            this.otherLOCATIONBOX.Location = new System.Drawing.Point(51, 263);
            this.otherLOCATIONBOX.Name = "otherLOCATIONBOX";
            this.otherLOCATIONBOX.Size = new System.Drawing.Size(67, 21);
            this.otherLOCATIONBOX.TabIndex = 10;
            this.otherLOCATIONBOX.Text = "OTHER";
            this.otherLOCATIONBOX.UseVisualStyleBackColor = true;
            // 
            // nycBOX
            // 
            this.nycBOX.AutoSize = true;
            this.nycBOX.Location = new System.Drawing.Point(30, 242);
            this.nycBOX.Name = "nycBOX";
            this.nycBOX.Size = new System.Drawing.Size(92, 21);
            this.nycBOX.TabIndex = 9;
            this.nycBOX.Text = "NEW YORK";
            this.nycBOX.UseVisualStyleBackColor = true;
            // 
            // provBOX
            // 
            this.provBOX.AutoSize = true;
            this.provBOX.Location = new System.Drawing.Point(30, 221);
            this.provBOX.Name = "provBOX";
            this.provBOX.Size = new System.Drawing.Size(103, 21);
            this.provBOX.TabIndex = 8;
            this.provBOX.Text = "PROVIDENCE";
            this.provBOX.UseVisualStyleBackColor = true;
            // 
            // bostonBOX
            // 
            this.bostonBOX.AutoSize = true;
            this.bostonBOX.Checked = true;
            this.bostonBOX.Location = new System.Drawing.Point(30, 203);
            this.bostonBOX.Name = "bostonBOX";
            this.bostonBOX.Size = new System.Drawing.Size(77, 21);
            this.bostonBOX.TabIndex = 7;
            this.bostonBOX.TabStop = true;
            this.bostonBOX.Text = "BOSTON";
            this.bostonBOX.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "CONNECTION SETTINGS";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(6, 147);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(358, 34);
            this.label22.TabIndex = 31;
            this.label22.Text = "All the above fields can be filled in using data from a single \r\n  UBER API reque" +
    "st packet.  See the README for more info";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.label15);
            this.mainPanel.Controls.Add(this.button6);
            this.mainPanel.Controls.Add(this.button5);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.label10);
            this.mainPanel.Controls.Add(this.label9);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.mapSelector);
            this.mainPanel.Controls.Add(this.incomStatusLabel);
            this.mainPanel.Controls.Add(this.timerLabel);
            this.mainPanel.Controls.Add(this.button4);
            this.mainPanel.Controls.Add(this.button3);
            this.mainPanel.Controls.Add(this.button2);
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.label8);
            this.mainPanel.Controls.Add(this.carBox);
            this.mainPanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainPanel.Location = new System.Drawing.Point(36, 76);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1340, 668);
            this.mainPanel.TabIndex = 4;
            this.mainPanel.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(726, 647);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 17);
            this.label15.TabIndex = 16;
            this.label15.Text = "Last Trip Analysis: Never";
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(150, 607);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(113, 47);
            this.button6.TabIndex = 15;
            this.button6.Text = "Pause Map Updating";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(16, 607);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 47);
            this.button5.TabIndex = 14;
            this.button5.Text = "Perform Trip Analysis";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.mapPausedLabel);
            this.panel1.Controls.Add(this.browserLoad);
            this.panel1.Controls.Add(this.tripAnaPanel);
            this.panel1.Controls.Add(this.waitPanel);
            this.panel1.Location = new System.Drawing.Point(277, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 581);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // mapPausedLabel
            // 
            this.mapPausedLabel.AutoSize = true;
            this.mapPausedLabel.BackColor = System.Drawing.Color.Transparent;
            this.mapPausedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mapPausedLabel.Location = new System.Drawing.Point(3, 559);
            this.mapPausedLabel.Name = "mapPausedLabel";
            this.mapPausedLabel.Size = new System.Drawing.Size(144, 17);
            this.mapPausedLabel.TabIndex = 2;
            this.mapPausedLabel.Text = "MAP UPDATES PAUSED";
            this.mapPausedLabel.Visible = false;
            // 
            // browserLoad
            // 
            this.browserLoad.Image = ((System.Drawing.Image)(resources.GetObject("browserLoad.Image")));
            this.browserLoad.Location = new System.Drawing.Point(-1, -1);
            this.browserLoad.Name = "browserLoad";
            this.browserLoad.Size = new System.Drawing.Size(35, 34);
            this.browserLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.browserLoad.TabIndex = 1;
            this.browserLoad.TabStop = false;
            this.browserLoad.Visible = false;
            // 
            // tripAnaPanel
            // 
            this.tripAnaPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tripAnaPanel.BackgroundImage")));
            this.tripAnaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tripAnaPanel.Controls.Add(this.button8);
            this.tripAnaPanel.Controls.Add(this.label14);
            this.tripAnaPanel.Controls.Add(this.button7);
            this.tripAnaPanel.Controls.Add(this.timeThresBox);
            this.tripAnaPanel.Controls.Add(this.distThresBox);
            this.tripAnaPanel.Controls.Add(this.label13);
            this.tripAnaPanel.Controls.Add(this.label12);
            this.tripAnaPanel.Controls.Add(this.label11);
            this.tripAnaPanel.Location = new System.Drawing.Point(548, 3);
            this.tripAnaPanel.Name = "tripAnaPanel";
            this.tripAnaPanel.Size = new System.Drawing.Size(495, 313);
            this.tripAnaPanel.TabIndex = 0;
            this.tripAnaPanel.Visible = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(326, 236);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(134, 45);
            this.button8.TabIndex = 7;
            this.button8.Text = "Start Analysis";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(25, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(430, 102);
            this.label14.TabIndex = 6;
            this.label14.Text = resources.GetString("label14.Text");
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(178, 236);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(134, 45);
            this.button7.TabIndex = 5;
            this.button7.Text = "Cancel";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // timeThresBox
            // 
            this.timeThresBox.BackColor = System.Drawing.Color.Black;
            this.timeThresBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeThresBox.ForeColor = System.Drawing.SystemColors.Window;
            this.timeThresBox.Location = new System.Drawing.Point(198, 76);
            this.timeThresBox.Name = "timeThresBox";
            this.timeThresBox.Size = new System.Drawing.Size(257, 25);
            this.timeThresBox.TabIndex = 4;
            // 
            // distThresBox
            // 
            this.distThresBox.BackColor = System.Drawing.Color.Black;
            this.distThresBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.distThresBox.ForeColor = System.Drawing.SystemColors.Window;
            this.distThresBox.Location = new System.Drawing.Point(198, 45);
            this.distThresBox.Name = "distThresBox";
            this.distThresBox.Size = new System.Drawing.Size(257, 25);
            this.distThresBox.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(25, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Time Threshold (Seconds)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(25, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Distance Threshold";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(4, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(318, 37);
            this.label11.TabIndex = 0;
            this.label11.Text = "PERFORM TRIP ANALYSIS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1227, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Trip Trends";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(815, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Routes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Heatmap";
            // 
            // mapSelector
            // 
            this.mapSelector.LargeChange = 3;
            this.mapSelector.Location = new System.Drawing.Point(394, 14);
            this.mapSelector.Maximum = 2;
            this.mapSelector.Name = "mapSelector";
            this.mapSelector.Size = new System.Drawing.Size(884, 45);
            this.mapSelector.TabIndex = 9;
            this.mapSelector.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mapSelector_MouseUp);
            // 
            // incomStatusLabel
            // 
            this.incomStatusLabel.AutoSize = true;
            this.incomStatusLabel.Location = new System.Drawing.Point(270, 648);
            this.incomStatusLabel.Name = "incomStatusLabel";
            this.incomStatusLabel.Size = new System.Drawing.Size(274, 17);
            this.incomStatusLabel.TabIndex = 8;
            this.incomStatusLabel.Text = "Recieved [X] updates / Processed [Y] updates";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(1152, 647);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(141, 17);
            this.timerLabel.TabIndex = 7;
            this.timerLabel.Text = "Tracking for 0 seconds";
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(150, 568);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 33);
            this.button4.TabIndex = 6;
            this.button4.Text = "Stop Tracking";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(16, 568);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "Refresh map";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(150, 532);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "Open Inspector";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(16, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save Raw Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(330, 37);
            this.label8.TabIndex = 2;
            this.label8.Text = "ACTIVE VEHICLES       MAP";
            // 
            // carBox
            // 
            this.carBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.carBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.carBox.FormattingEnabled = true;
            this.carBox.ItemHeight = 17;
            this.carBox.Location = new System.Drawing.Point(16, 64);
            this.carBox.Name = "carBox";
            this.carBox.Size = new System.Drawing.Size(247, 461);
            this.carBox.TabIndex = 0;
            this.carBox.SelectedIndexChanged += new System.EventHandler(this.carBox_SelectedIndexChanged);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logoutButton.Location = new System.Drawing.Point(1345, 5);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(66, 45);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Visible = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // runningTimer
            // 
            this.runningTimer.Interval = 1000;
            this.runningTimer.Tick += new System.EventHandler(this.runningTimer_Tick);
            // 
            // fileReaderUpdater
            // 
            this.fileReaderUpdater.Tick += new System.EventHandler(this.fileReaderUpdater_Tick);
            // 
            // onlineUpdater
            // 
            this.onlineUpdater.Tick += new System.EventHandler(this.onlineUpdater_Tick);
            // 
            // tripAnaTimer
            // 
            this.tripAnaTimer.Interval = 10000;
            this.tripAnaTimer.Tick += new System.EventHandler(this.tripAnaTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1276, 751);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.CONTROLLABEL);
            this.Controls.Add(this.mainPB);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "UBER POINTERIZER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.waitPanel.ResumeLayout(false);
            this.waitPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.browserLoad)).EndInit();
            this.tripAnaPanel.ResumeLayout(false);
            this.tripAnaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel waitPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar mainPB;
        private System.Windows.Forms.Label CONTROLLABEL;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Button connectBOX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lonBox;
        private System.Windows.Forms.RadioButton otherLOCATIONBOX;
        private System.Windows.Forms.RadioButton nycBOX;
        private System.Windows.Forms.RadioButton provBOX;
        private System.Windows.Forms.RadioButton bostonBOX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox carBox;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label loginErrorLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer runningTimer;
        private System.Windows.Forms.Label incomStatusLabel;
        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.Timer fileReaderUpdater;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar mapSelector;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer onlineUpdater;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel tripAnaPanel;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox timeThresBox;
        private System.Windows.Forms.TextBox distThresBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer tripAnaTimer;
        private System.Windows.Forms.PictureBox browserLoad;
        private System.Windows.Forms.Label mapPausedLabel;
        private System.Windows.Forms.TextBox latBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox md5BOX;
        private System.Windows.Forms.TextBox uberidBOX;
        private System.Windows.Forms.TextBox adBOX;
        private System.Windows.Forms.TextBox tokenBOX;
        private System.Windows.Forms.Label label22;
    }
}

