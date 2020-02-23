using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UtopiaCryptocards
{
	public partial class MainForm : Form
	{
		void showMessage(string info = "") {
			MessageBox.Show(info, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		bool isClientConnected() {
			bool is_connected;
			if(client == null) {
				is_connected = false;
			} else {
				is_connected = client.checkClientConnection();
			}
			
			if(!is_connected) {
				printToLog("No active client connection");
			}
			return is_connected;
		}
		
		void updateCardsList() {
			if(!isClientConnected()) { return; }
			
			//int image_index = 0;
			listView1.Items.Clear();
			
			JArray cards_arr = client.getCards();
			for(int i=0; i < cards_arr.Count; i++) {
				JObject card_info = cards_arr[i] as JObject;
				string cardID = card_info["cardid"].ToString();
				
				ListViewItem new_item = new ListViewItem(cardID);
				
				listView1.Items.Add(new_item);
			}
		}
	}
}
