using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Bank
{
    class Player
    {
        // Here we're creating a constructor with 2 parameters
        public Player(string name, int money)
        {
            // Set the player name equal to the 'name' parameter
            this.playerName = name;
            // Set the player money equal to the 'money' parameter
            this.playerMoney = money;
        }

        public string playerName
        {
            // Here we get the player's name
            get;
            // Here we set the player's name
            set;
        }

        public int playerMoney
        {
            // Here we get the player's money
            get;
            // Here we set the player's money
            set;
        }

        public int passedGo
        {
            // Here we get how many times the player has passed go
            get;
            // Here we set how many times the player has passed go
            set;
        }
    }
}
