using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;

namespace UtopiaCryptocards
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		UtopiaLib.Client client;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void openURL(string url = "https://example.com") {
			Process.Start(url);
		}
		
		void ViewGithubClick(object sender, EventArgs e)
		{
			openURL("https://github.com/Sagleft/utopia-csharp-template");
		}
		
		void ButtonVisitSiteClick(object sender, EventArgs e)
		{
			openURL("https://u.is");
		}
		
		void printToLog(string info = "") {
			textBox_connectionLog.AppendText(" > " + info + Environment.NewLine);
		}
		
		void ButtonConnectClick(object sender, EventArgs e)
		{
			string api_host = textBox_host.Text;
			string api_token = textBox_token.Text;
			int api_port = 22800;
			if(! Int32.TryParse(textBox_port.Text, out api_port)) {
				printToLog("Failed to parse port, using default value: " + 22800);
			}
			
			printToLog("attempt to connect to the Utopia client..");
			try {
				client = new UtopiaLib.Client(api_host, api_port, api_token);
				if(client.checkClientConnection()) {
					printToLog("successful connection!");
				} else {
					printToLog("failed to connect to client");
				}
			} catch (Exception ex) {
				printToLog("catched exception: " + ex.Message);
			}
			
		}
	}
}
