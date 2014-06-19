using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly_Bank
{
    public partial class Form1 : Form
    {

        ArrayList playerList = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (txtAddPlayer.Text.Trim() != "")
            {
                if (!(lbPlayers.Items.Contains(txtAddPlayer.Text)))
                {
                    playerList.Add(new Player(txtAddPlayer.Text, 100));
                    lbPlayers.Items.Add(txtAddPlayer.Text);
                    cbPlayerList.Items.Add(txtAddPlayer.Text);
                    cbPlayerListPay.Items.Add(txtAddPlayer.Text);

                    txtConsole.AppendText(txtAddPlayer.Text + " has joined the game. " + DateTime.Now.ToString("h:mm tt") + "\n");

                    txtAddPlayer.Clear();
                }
                else
                {
                    MessageBox.Show("That username is already taken!");

                    txtAddPlayer.Clear();
                }
            }
            else
            {
                MessageBox.Show("A player name is required!");
            }
        }

        private void lbPlayers_MouseClick(object sender, MouseEventArgs e)
        {
            string selected = lbPlayers.GetItemText(lbPlayers.SelectedItem);

            foreach (Player selectedPlayer in playerList)
            {
                if (selectedPlayer.playerName == selected)
                {
                    // Load the selected player's information
                    txtBalance.Text = selectedPlayer.playerMoney.ToString();
                    
                    break;
                }
            }
        }

        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            string selectedItem = cbPlayerList.GetItemText(cbPlayerList.SelectedItem);

            foreach (Player selectedPlayer in playerList)
            {
                if (selectedPlayer.playerName == selectedItem)
                {
                    playerList.Remove(selectedItem);
                    lbPlayers.Items.Remove(selectedItem);
                    cbPlayerList.Items.Remove(selectedItem);
                    cbPlayerListPay.Items.Remove(selectedItem);

                    txtConsole.AppendText(selectedItem + " has left the game. " + DateTime.Now.ToString("h:mm tt") + "\n");
                    
                    break;
                }
            }
        }

        private void btnPayPlayer_Click(object sender, EventArgs e)
        {
            string selected = lbPlayers.GetItemText(lbPlayers.SelectedItem);
            string selectedPlayerPay = cbPlayerListPay.GetItemText(cbPlayerListPay.SelectedItem);

            foreach (Player selectedPlayer in playerList)
            {
                if(selectedPlayerPay == selectedPlayer.playerName){
                    selectedPlayer.playerMoney += int.Parse(txtPayAmount.Text);

                    txtConsole.AppendText(selected + " sent " + selectedPlayerPay + " " + txtPayAmount.Text + "\n");

                    txtPayAmount.Text = "";
                }
            }
        }
    }
}
