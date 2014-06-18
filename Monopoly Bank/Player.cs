using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_Bank
{
    class Player
    {
        public Player(string name, int money)
        {
            this.playerName = name;
            this.playerMoney = money;
        }

        public string playerName
        {
            get;
            set;
        }

        public int playerMoney
        {
            get;
            set;
        }
    }
}
