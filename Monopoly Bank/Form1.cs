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

        // Set default variables the starting money and passing go money
        int startMoney = 0;
        int passGoAmount = 0;

        // Get the current date and time
        string currentTime = DateTime.Now.ToString("h:mm tt");

        // Create a new array list of players
        ArrayList playerList = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        // Here we add a new player
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            // Check if the add player box is not empty or has any white space
            if (txtAddPlayer.Text.Trim() != "")
            {
                // Check if the player is already in the list box
                if (!(lbPlayers.Items.Contains(txtAddPlayer.Text)))
                {
                    // Here we create a new player with their chosen name and the default starting money
                    playerList.Add(new Player(txtAddPlayer.Text, startMoney));
                    // Add the player's name to the appropriate boxes
                    lbPlayers.Items.Add(txtAddPlayer.Text);
                    cbPlayerList.Items.Add(txtAddPlayer.Text);
                    cbPlayerListPay.Items.Add(txtAddPlayer.Text);
                    // Write to the console the following message
                    txtConsole.AppendText(txtAddPlayer.Text + " has joined the game " + currentTime + "\n");
                    // Clear the add player text box
                    txtAddPlayer.Clear();
                }
                else
                {
                    // Display a message box for the error
                    MessageBox.Show("That username is already taken!");
                    // Clear the add player text box
                    txtAddPlayer.Clear();
                }
            }
            else
            {
                // Display a message box for the error
                MessageBox.Show("A player name is required!");
            }
        }
        // Here we're clicking on a player in the list box
        private void lbPlayers_MouseClick(object sender, MouseEventArgs e)
        {
            // Store the selected item in the list box as a variable
            string selected = lbPlayers.GetItemText(lbPlayers.SelectedItem);
            // Loop through the player's in the player list
            foreach (Player selectedPlayer in playerList)
            {
                // Check if the selected item matches the player name in the array list
                if (selected == selectedPlayer.playerName)
                {
                    // Load the selected player's information
                    txtBalance.Text = selectedPlayer.playerMoney.ToString();
                    txtTimesPassedGo.Text = selectedPlayer.passedGo.ToString();
                    // Break out of the loop
                    break;
                }
            }
        }
        // Here we're deleting the selected player
        private void btnDeletePlayer_Click(object sender, EventArgs e)
        {
            // Store the selected item in the list box as a variable
            string selectedItem = cbPlayerList.GetItemText(cbPlayerList.SelectedItem);
            // Loop through the player's in the player list
            foreach (Player selectedPlayer in playerList)
            {
                // Check if the selected item matches the player name in the array list
                if (selectedItem == selectedPlayer.playerName)
                {
                    // Delete the player from the array list and from the list boxes
                    playerList.Remove(selectedItem);
                    lbPlayers.Items.Remove(selectedItem);
                    cbPlayerList.Items.Remove(selectedItem);
                    cbPlayerListPay.Items.Remove(selectedItem);
                    // Write to the console that the selected player has left the game
                    txtConsole.AppendText(selectedItem + " has left the game " + currentTime + "\n");
                    // Break out of the loop
                    break;
                }
            }
        }
        // Here we're sending another player money
        private void btnPayPlayer_Click(object sender, EventArgs e)
        {
            // Store the selected item in the list box as a variable
            string selected = lbPlayers.GetItemText(lbPlayers.SelectedItem);
            // Store the selected item in the combo box as a variable
            string selectedPlayerPay = cbPlayerListPay.GetItemText(cbPlayerListPay.SelectedItem);
            // Loop through the player's in the player list
            foreach (Player selectedPlayer in playerList)
            {
                // Check if the pay amount is not empty
                if (txtPayAmount.Text.Trim().ToString() != "")
                {
                    // Check if the pay amount is not less than 0
                    if (!(int.Parse(txtPayAmount.Text) < 0))
                    {
                        // Check if the the selected player to pay matches a selected player in the player list
                        if (selectedPlayerPay == selectedPlayer.playerName)
                        {
                            // Add the money to the selected player's account
                            selectedPlayer.playerMoney += int.Parse(txtPayAmount.Text);
                            // Write to the console what happened
                            txtConsole.AppendText(selected + " sent " + selectedPlayerPay + " " + txtPayAmount.Text + " " + currentTime + "\n");
                            // Set the pay amount text box to nothing
                            txtPayAmount.Text = "";
                        }
                        // Check if the selected player in the list box matches the one in the player list
                        if (selected == selectedPlayer.playerName)
                        {
                            // Take the money from their account
                            selectedPlayer.playerMoney -= int.Parse(txtPayAmount.Text);
                        }
                    }
                    else
                    {
                        // Display a message box with the error
                        MessageBox.Show("Amount cannot be below 0!");
                    }
                }
                else
                {
                    // Display a message box with the error
                    MessageBox.Show("Amount cannot be empty!");
                }
            }
        }
        // Here we're setting the starting money
        private void btnSetStartingMoney_Click(object sender, EventArgs e)
        {
            // Store the starting amount text as a variable
            string startingMoneyAmoutBox = txtStartingMoneyAmount.Text.Trim();
            // Check to see if the starting amount text box is not empty
            if (startingMoneyAmoutBox.ToString() != "")
            {
                // Check to see if the starting amount is not less than 0
                if (!(int.Parse(startingMoneyAmoutBox) < 0 ))
                {
                    // Assign the start money variable to the amount that was entered in the text box
                    startMoney = int.Parse(startingMoneyAmoutBox);
                    // Disable the starting amount text box
                    txtStartingMoneyAmount.Enabled = false;
                    // Disable the starting amount button
                    btnSetStartingMoney.Enabled = false;
                    
                    // Just incase you add the players first and then set the start money amount
                    foreach (Player playersInList in playerList)
                    {
                        // If the player's money is 0
                        if (playersInList.playerMoney == 0)
                        {
                            // Set the player's money to the start money variable
                            playersInList.playerMoney = startMoney;
                        }
                    }
                    // Write to the console
                    txtConsole.AppendText(startMoney.ToString());
                }
                else
                {
                    // Display a message box with the error
                    MessageBox.Show("The amount cannot be below 0!");
                }
            }
            else
            {
                // Display a message box with the error
                MessageBox.Show("A starting amount is needed!");
            }
        }
        // Here we're setting the money that you collect when you pass go
        private void txtSetPassGoAmount_Click(object sender, EventArgs e)
        {
            // Assign the text in the pass go amount text box to a variable
            string setGoMoneyAmoutbox = txtPassGoAmount.Text.Trim();
            // Check if the pass go amount is not empty
            if (setGoMoneyAmoutbox.ToString() != "")
            {
                // Check and get the valid pass amount
                if (int.TryParse(setGoMoneyAmoutbox, out passGoAmount))
                {
                    // Make sure the pass amount is more than zero
                    if (passGoAmount > 0)
                    {
                        // Disable the pass go amount text box
                        txtPassGoAmount.Enabled = false;
                        // Disable the pass go amount button
                        btnSetPassGoAmount.Enabled = false;
                        // Write to the console what happened
                        txtConsole.AppendText("Players will now get " + passGoAmount + " each time they pass go " + currentTime + "\n");
                    }
                    else
                    {
                        // Display a message box with the error
                        MessageBox.Show("The amount cannot be below 1!");
                    }
                }
                else
                {
                    // Display a message box with the error
                    MessageBox.Show("The amount is not valid!");
                }
            }
            else
            {
                // Display a message box with the error
                MessageBox.Show("You need to enter an amount!");
            }
        }
        // Here we pay the player once the pass go
        private void btnPassGo_Click(object sender, EventArgs e)
        {
            // Retrieve the Player object for the currently selected player in the list
            Player selectedPlayer = getPlayerData(lbPlayers.GetItemText(lbPlayers.SelectedItem));
            // Make sure there is a player selected
            if (selectedPlayer != null)
            {
                // Check if the pass go amount is not equal to 0
                if (passGoAmount != 0)
                {
                    // Add the pass go amount to the player's account
                    selectedPlayer.playerMoney += passGoAmount;
                    // Add 1 to the player's pass go variable
                    selectedPlayer.passedGo += 1;
                    // Write to console what happened
                    txtConsole.AppendText(selectedPlayer.playerName + " passed go! " + currentTime + "\n");
                }
                else
                {
                    // Display a message box with the error
                    MessageBox.Show("Did you forget to set the pass go amount?");
                }
            }
        }
        private Player getPlayerData(string playerName)
        {
            // Loop through the player's in the player list
            foreach (Player player in playerList)
            {
                if (player.playerName == playerName)
                {
                    return player;
                }
            }
            return null;
        }
    }
}
