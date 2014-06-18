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
                playerList.Add(new Player(txtAddPlayer.Text, 100));
                lbPlayers.Items.Add(txtAddPlayer.Text);

                txtAddPlayer.Clear();
            }
            else
            {
                MessageBox.Show("A player name is required!");
            }
        }

        private void lbPlayers_MouseClick(object sender, MouseEventArgs e)
        {
            string selected = lbPlayers.GetItemText(lbPlayers.SelectedItem);

            foreach(Player selectedPlayer in playerList)
            {
                if (selectedPlayer.playerName == selected)
                {
                    MessageBox.Show(selectedPlayer.playerName + selectedPlayer.playerMoney);
                    break;
                }
            }
        }
    }
}
