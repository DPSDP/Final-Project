using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_DSDP_EX3
{
   public class Player
    {
        string alias { get;  }
        bool Injail { get; set; }
        public Position pos { get; set; }

        public Player(string alias)
        {
            this.alias = alias;
            this.Injail = false;
            this.pos = new Position(); //A modifier


        }
        public Player(string alias,bool Injail, Position pos)
        {
            this.alias = alias;
            this.Injail = Injail;
            this.pos = pos;


        }

    }
   
}
