using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projet_Final_DSDP_EX3
{
    class Board
    {
        List<Player> Players { get;  }
        Player currentplayer { get; set; }

        public Board(List<string> PlayersNames)
        {
            foreach(string name in PlayersNames)
            {
                Player p = new Player(name);
            }
            
            this.Players = Players;
            this.currentplayer = currentplayer;
        }

    }
}
