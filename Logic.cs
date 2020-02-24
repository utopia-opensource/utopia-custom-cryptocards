using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
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
		
		void BtnChooseColorClick(object sender, EventArgs e)
		{
			Color new_color;
			DialogResult result = colorDialog1.ShowDialog();
			if(result == DialogResult.OK) {
				new_color = colorDialog1.Color;
				string hex = new_color.R.ToString("X2") + new_color.G.ToString("X2") + new_color.B.ToString("X2");
				newCardColor.Text = hex;
			}
		}
		
		void BtnColorsGoldClick(object sender, EventArgs e)
		{
			newCardColor.Text = "FFD700";
		}
		
		void BtnColorsBlackClick(object sender, EventArgs e)
		{
			newCardColor.Text = "000000";
		}
		
		void BtnColorsGreenClick(object sender, EventArgs e)
		{
			newCardColor.Text = "39db7f";
		}
		
		void BtnCreateCardClick(object sender, EventArgs e)
		{
			if(!isClientConnected()) {
				showMessage("No active client connection");
				return;
			}
			
			string result = client.addCard(newCardName.Text, newCardColor.Text, newCardCharacters.Text);
			updateCardsList();
			showMessage("OK! cardID: " + result);
		}
	}
}
