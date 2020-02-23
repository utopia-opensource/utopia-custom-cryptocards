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
			listBox1.Items.Clear();
			
			JArray cards_arr = client.getCards();
			for(int i=0; i < cards_arr.Count; i++) {
				JObject card_info = cards_arr[i] as JObject;
				string cardID = card_info["cardid"].ToString();
				listBox1.Items.Add(cardID);
				
				if(cards_arr.Count > 0) {
					listBox1.SelectedIndex = 0;
					loadCardInfo();
				}
			}
		}
		
		void loadCardInfo() {
			int card_index = listBox1.SelectedIndex;
			string cardID  = listBox1.Items[card_index].ToString();
			if(card_index >= 0) {
				JObject card_info = client.getCardInfo(cardID);
				
				cardDataID.Text = cardID;
				cardDataBalance.Text = card_info["balance"].ToString() + " CRP";
				cardDataCreated.Text = card_info["created"].ToString();
				cardDataColor.Text   = card_info["color"].ToString();
				cardDataName.Text    = card_info["name"].ToString();
			}
		}
		
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			loadCardInfo();
		}
	}
}
