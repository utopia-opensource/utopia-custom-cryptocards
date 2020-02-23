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
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel2;
		
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
			this.label5 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.buttonVisitSite = new System.Windows.Forms.Button();
			this.viewGithub = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(537, 346);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(529, 317);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Connection";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.buttonClearLog);
			this.groupBox2.Controls.Add(this.textBox_connectionLog);
			this.groupBox2.Location = new System.Drawing.Point(293, 6);
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
			this.groupBox1.Location = new System.Drawing.Point(8, 6);
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
			this.textBox_port.Size = new System.Drawing.Size(158, 22);
			this.textBox_port.TabIndex = 10;
			this.textBox_port.Text = "22824";
			this.textBox_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox_token
			// 
			this.textBox_token.Location = new System.Drawing.Point(92, 38);
			this.textBox_token.Name = "textBox_token";
			this.textBox_token.Size = new System.Drawing.Size(158, 22);
			this.textBox_token.TabIndex = 11;
			this.textBox_token.Text = "1FDECB36C3514BD245CCCF71286ABDEF";
			this.textBox_token.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textBox_host
			// 
			this.textBox_host.Location = new System.Drawing.Point(92, 10);
			this.textBox_host.Name = "textBox_host";
			this.textBox_host.Size = new System.Drawing.Size(158, 22);
			this.textBox_host.TabIndex = 12;
			this.textBox_host.Text = "http://127.0.0.1";
			this.textBox_host.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(529, 317);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Section";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(23, 99);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(479, 77);
			this.label5.TabIndex = 0;
			this.label5.Text = "Your controls may be here.";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.buttonVisitSite);
			this.tabPage3.Controls.Add(this.viewGithub);
			this.tabPage3.Controls.Add(this.label4);
			this.tabPage3.Controls.Add(this.pictureBox1);
			this.tabPage3.Controls.Add(this.panel2);
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(529, 317);
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
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(182, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(339, 153);
			this.label4.TabIndex = 1;
			this.label4.Text = "C# ready-made MVP application template\r\nfor starting the development of your util" +
	"ity,\r\nworking with the Utopia Ecosystem API";
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
			this.panel2.Size = new System.Drawing.Size(176, 317);
			this.panel2.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(537, 346);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Utopia App Template";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
