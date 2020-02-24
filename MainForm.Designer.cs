namespace UtopiaCryptocards
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_host;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonConnect;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_port;
		private System.Windows.Forms.TextBox textBox_token;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button viewGithub;
		private System.Windows.Forms.Button buttonVisitSite;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonClearLog;
		private System.Windows.Forms.TextBox textBox_connectionLog;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label cardDataCreated;
		private System.Windows.Forms.Label cardDataName;
		private System.Windows.Forms.Label cardDataColor;
		private System.Windows.Forms.Label cardDataBalance;
		private System.Windows.Forms.Label cardDataID;
		private System.Windows.Forms.TextBox newCardName;
		private System.Windows.Forms.TextBox newCardColor;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnCreateCard;
		private System.Windows.Forms.TextBox newCardCharacters;
		private System.Windows.Forms.Button btnChooseColor;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Button btnColorsGold;
		private System.Windows.Forms.Button btnColorsBlack;
		private System.Windows.Forms.Button btnColorsGreen;
		private System.Windows.Forms.Label label14;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.buttonClearLog = new System.Windows.Forms.Button();
			this.textBox_connectionLog = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonConnect = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_port = new System.Windows.Forms.TextBox();
			this.textBox_token = new System.Windows.Forms.TextBox();
			this.textBox_host = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cardDataCreated = new System.Windows.Forms.Label();
			this.cardDataName = new System.Windows.Forms.Label();
			this.cardDataColor = new System.Windows.Forms.Label();
			this.cardDataBalance = new System.Windows.Forms.Label();
			this.cardDataID = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.label14 = new System.Windows.Forms.Label();
			this.btnColorsGreen = new System.Windows.Forms.Button();
			this.btnColorsBlack = new System.Windows.Forms.Button();
			this.btnColorsGold = new System.Windows.Forms.Button();
			this.btnChooseColor = new System.Windows.Forms.Button();
			this.newCardName = new System.Windows.Forms.TextBox();
			this.newCardCharacters = new System.Windows.Forms.TextBox();
			this.newCardColor = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.btnCreateCard = new System.Windows.Forms.Button();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.buttonVisitSite = new System.Windows.Forms.Button();
			this.viewGithub = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.tabPage4.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(782, 553);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 29);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(774, 520);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Connection";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.buttonClearLog);
			this.groupBox2.Controls.Add(this.textBox_connectionLog);
			this.groupBox2.Location = new System.Drawing.Point(422, 92);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(228, 303);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "connection status";
			// 
			// buttonClearLog
			// 
			this.buttonClearLog.Location = new System.Drawing.Point(15, 266);
			this.buttonClearLog.Name = "buttonClearLog";
			this.buttonClearLog.Size = new System.Drawing.Size(207, 31);
			this.buttonClearLog.TabIndex = 1;
			this.buttonClearLog.Text = "clear";
			this.buttonClearLog.UseVisualStyleBackColor = true;
			this.buttonClearLog.Click += new System.EventHandler(this.ButtonClearLogClick);
			// 
			// textBox_connectionLog
			// 
			this.textBox_connectionLog.Location = new System.Drawing.Point(15, 30);
			this.textBox_connectionLog.Multiline = true;
			this.textBox_connectionLog.Name = "textBox_connectionLog";
			this.textBox_connectionLog.Size = new System.Drawing.Size(207, 229);
			this.textBox_connectionLog.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Location = new System.Drawing.Point(137, 92);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(279, 303);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "data to connect to the client";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonConnect);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.textBox_port);
			this.panel1.Controls.Add(this.textBox_token);
			this.panel1.Controls.Add(this.textBox_host);
			this.panel1.Location = new System.Drawing.Point(6, 30);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(267, 145);
			this.panel1.TabIndex = 10;
			// 
			// buttonConnect
			// 
			this.buttonConnect.Location = new System.Drawing.Point(92, 94);
			this.buttonConnect.Name = "buttonConnect";
			this.buttonConnect.Size = new System.Drawing.Size(158, 41);
			this.buttonConnect.TabIndex = 16;
			this.buttonConnect.Text = "connect";
			this.buttonConnect.UseVisualStyleBackColor = true;
			this.buttonConnect.Click += new System.EventHandler(this.ButtonConnectClick);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 23);
			this.label3.TabIndex = 13;
			this.label3.Text = "port";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 37);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 23);
			this.label2.TabIndex = 14;
			this.label2.Text = "token";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 23);
			this.label1.TabIndex = 15;
			this.label1.Text = "host";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// textBox_port
			// 
			this.textBox_port.Location = new System.Drawing.Point(92, 66);
			this.textBox_port.Name = "textBox_port";
			this.textBox_port.Size = new System.Drawing.Size(158, 27);
			this.textBox_port.TabIndex = 10;
			this.textBox_port.Text = "22000";
			this.textBox_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox_token
			// 
			this.textBox_token.Location = new System.Drawing.Point(92, 38);
			this.textBox_token.Name = "textBox_token";
			this.textBox_token.Size = new System.Drawing.Size(158, 27);
			this.textBox_token.TabIndex = 11;
			this.textBox_token.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox_host
			// 
			this.textBox_host.Location = new System.Drawing.Point(92, 10);
			this.textBox_host.Name = "textBox_host";
			this.textBox_host.Size = new System.Drawing.Size(158, 27);
			this.textBox_host.TabIndex = 12;
			this.textBox_host.Text = "http://127.0.0.1";
			this.textBox_host.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.cardDataCreated);
			this.tabPage2.Controls.Add(this.cardDataName);
			this.tabPage2.Controls.Add(this.cardDataColor);
			this.tabPage2.Controls.Add(this.cardDataBalance);
			this.tabPage2.Controls.Add(this.cardDataID);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.pictureBox2);
			this.tabPage2.Controls.Add(this.listBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 29);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(774, 520);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "My Cards";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(282, 166);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(105, 23);
			this.label10.TabIndex = 3;
			this.label10.Text = "Created:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(282, 143);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(105, 23);
			this.label9.TabIndex = 3;
			this.label9.Text = "Name:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(282, 120);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(105, 23);
			this.label8.TabIndex = 3;
			this.label8.Text = "Color:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(282, 97);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(105, 23);
			this.label7.TabIndex = 3;
			this.label7.Text = "Balance:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cardDataCreated
			// 
			this.cardDataCreated.Location = new System.Drawing.Point(393, 166);
			this.cardDataCreated.Name = "cardDataCreated";
			this.cardDataCreated.Size = new System.Drawing.Size(361, 23);
			this.cardDataCreated.TabIndex = 3;
			this.cardDataCreated.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cardDataName
			// 
			this.cardDataName.Location = new System.Drawing.Point(393, 143);
			this.cardDataName.Name = "cardDataName";
			this.cardDataName.Size = new System.Drawing.Size(361, 23);
			this.cardDataName.TabIndex = 3;
			this.cardDataName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cardDataColor
			// 
			this.cardDataColor.Location = new System.Drawing.Point(393, 120);
			this.cardDataColor.Name = "cardDataColor";
			this.cardDataColor.Size = new System.Drawing.Size(361, 23);
			this.cardDataColor.TabIndex = 3;
			this.cardDataColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cardDataBalance
			// 
			this.cardDataBalance.Location = new System.Drawing.Point(393, 97);
			this.cardDataBalance.Name = "cardDataBalance";
			this.cardDataBalance.Size = new System.Drawing.Size(361, 23);
			this.cardDataBalance.TabIndex = 3;
			this.cardDataBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cardDataID
			// 
			this.cardDataID.Location = new System.Drawing.Point(393, 74);
			this.cardDataID.Name = "cardDataID";
			this.cardDataID.Size = new System.Drawing.Size(361, 23);
			this.cardDataID.TabIndex = 3;
			this.cardDataID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(282, 74);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(105, 23);
			this.label6.TabIndex = 3;
			this.label6.Text = "ID:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(261, 20);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(493, 39);
			this.label5.TabIndex = 2;
			this.label5.Text = "details";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(91, 20);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(73, 39);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(18, 74);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(233, 424);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1SelectedIndexChanged);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.label14);
			this.tabPage4.Controls.Add(this.btnColorsGreen);
			this.tabPage4.Controls.Add(this.btnColorsBlack);
			this.tabPage4.Controls.Add(this.btnColorsGold);
			this.tabPage4.Controls.Add(this.btnChooseColor);
			this.tabPage4.Controls.Add(this.newCardName);
			this.tabPage4.Controls.Add(this.newCardCharacters);
			this.tabPage4.Controls.Add(this.newCardColor);
			this.tabPage4.Controls.Add(this.label11);
			this.tabPage4.Controls.Add(this.label13);
			this.tabPage4.Controls.Add(this.label12);
			this.tabPage4.Controls.Add(this.btnCreateCard);
			this.tabPage4.Location = new System.Drawing.Point(4, 29);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(774, 520);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Create card";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(543, 158);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(81, 30);
			this.label14.TabIndex = 9;
			this.label14.Text = "hex";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnColorsGreen
			// 
			this.btnColorsGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(219)))), ((int)(((byte)(127)))));
			this.btnColorsGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnColorsGreen.Location = new System.Drawing.Point(644, 125);
			this.btnColorsGreen.Name = "btnColorsGreen";
			this.btnColorsGreen.Size = new System.Drawing.Size(27, 27);
			this.btnColorsGreen.TabIndex = 8;
			this.btnColorsGreen.UseVisualStyleBackColor = false;
			this.btnColorsGreen.Click += new System.EventHandler(this.BtnColorsGreenClick);
			// 
			// btnColorsBlack
			// 
			this.btnColorsBlack.BackColor = System.Drawing.Color.Black;
			this.btnColorsBlack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnColorsBlack.Location = new System.Drawing.Point(611, 125);
			this.btnColorsBlack.Name = "btnColorsBlack";
			this.btnColorsBlack.Size = new System.Drawing.Size(27, 27);
			this.btnColorsBlack.TabIndex = 8;
			this.btnColorsBlack.UseVisualStyleBackColor = false;
			this.btnColorsBlack.Click += new System.EventHandler(this.BtnColorsBlackClick);
			// 
			// btnColorsGold
			// 
			this.btnColorsGold.BackColor = System.Drawing.Color.Gold;
			this.btnColorsGold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnColorsGold.Location = new System.Drawing.Point(578, 125);
			this.btnColorsGold.Name = "btnColorsGold";
			this.btnColorsGold.Size = new System.Drawing.Size(27, 27);
			this.btnColorsGold.TabIndex = 8;
			this.btnColorsGold.UseVisualStyleBackColor = false;
			this.btnColorsGold.Click += new System.EventHandler(this.BtnColorsGoldClick);
			// 
			// btnChooseColor
			// 
			this.btnChooseColor.Location = new System.Drawing.Point(543, 125);
			this.btnChooseColor.Name = "btnChooseColor";
			this.btnChooseColor.Size = new System.Drawing.Size(29, 27);
			this.btnChooseColor.TabIndex = 7;
			this.btnChooseColor.Text = "...";
			this.btnChooseColor.UseVisualStyleBackColor = true;
			this.btnChooseColor.Click += new System.EventHandler(this.BtnChooseColorClick);
			// 
			// newCardName
			// 
			this.newCardName.Location = new System.Drawing.Point(363, 92);
			this.newCardName.Name = "newCardName";
			this.newCardName.Size = new System.Drawing.Size(174, 27);
			this.newCardName.TabIndex = 6;
			this.newCardName.Text = "my cryptocard";
			this.newCardName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// newCardCharacters
			// 
			this.newCardCharacters.Location = new System.Drawing.Point(363, 158);
			this.newCardCharacters.MaxLength = 4;
			this.newCardCharacters.Name = "newCardCharacters";
			this.newCardCharacters.Size = new System.Drawing.Size(174, 27);
			this.newCardCharacters.TabIndex = 6;
			this.newCardCharacters.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// newCardColor
			// 
			this.newCardColor.Location = new System.Drawing.Point(363, 125);
			this.newCardColor.MaxLength = 6;
			this.newCardColor.Name = "newCardColor";
			this.newCardColor.Size = new System.Drawing.Size(174, 27);
			this.newCardColor.TabIndex = 6;
			this.newCardColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(184, 165);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(173, 23);
			this.label11.TabIndex = 4;
			this.label11.Text = "Custom characters:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(184, 92);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(173, 27);
			this.label13.TabIndex = 5;
			this.label13.Text = "Card name:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(184, 125);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(173, 27);
			this.label12.TabIndex = 5;
			this.label12.Text = "Color:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnCreateCard
			// 
			this.btnCreateCard.Location = new System.Drawing.Point(363, 191);
			this.btnCreateCard.Name = "btnCreateCard";
			this.btnCreateCard.Size = new System.Drawing.Size(174, 35);
			this.btnCreateCard.TabIndex = 0;
			this.btnCreateCard.Text = "create card";
			this.btnCreateCard.UseVisualStyleBackColor = true;
			this.btnCreateCard.Click += new System.EventHandler(this.BtnCreateCardClick);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.buttonVisitSite);
			this.tabPage3.Controls.Add(this.viewGithub);
			this.tabPage3.Controls.Add(this.label4);
			this.tabPage3.Controls.Add(this.pictureBox1);
			this.tabPage3.Controls.Add(this.panel2);
			this.tabPage3.Location = new System.Drawing.Point(4, 29);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(774, 520);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "About";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// buttonVisitSite
			// 
			this.buttonVisitSite.Location = new System.Drawing.Point(8, 207);
			this.buttonVisitSite.Name = "buttonVisitSite";
			this.buttonVisitSite.Size = new System.Drawing.Size(158, 30);
			this.buttonVisitSite.TabIndex = 2;
			this.buttonVisitSite.Text = "visit u.is";
			this.buttonVisitSite.UseVisualStyleBackColor = true;
			this.buttonVisitSite.Click += new System.EventHandler(this.ButtonVisitSiteClick);
			// 
			// viewGithub
			// 
			this.viewGithub.Location = new System.Drawing.Point(8, 171);
			this.viewGithub.Name = "viewGithub";
			this.viewGithub.Size = new System.Drawing.Size(158, 30);
			this.viewGithub.TabIndex = 2;
			this.viewGithub.Text = "view on Github";
			this.viewGithub.UseVisualStyleBackColor = true;
			this.viewGithub.Click += new System.EventHandler(this.ViewGithubClick);
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(176, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(598, 520);
			this.label4.TabIndex = 1;
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Black;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(8, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(158, 153);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Black;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(176, 520);
			this.panel2.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(782, 553);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "Utopia custom cryptocards";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
