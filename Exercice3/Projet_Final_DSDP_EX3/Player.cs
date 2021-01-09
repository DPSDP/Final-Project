using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_DSDP_EX3
{
   public class Player
    {
        public string alias { get;  }
        public bool Injail { get; set; }
        public Position pos { get; set; }

        public Player(string alias)
        {
            this.alias = alias;
            this.Injail = false;
            this.pos = new Position();


        }
        public Player(string alias,bool Injail, Position pos)
        {
            this.alias = alias;
            this.Injail = Injail;
            this.pos = pos;


        }
        public void Play()
        {
            Dices.Roll(this);

            
           
            
        }
        public void goToJail()
        {
            this.Injail = true;
            this.pos.numPos = 10;
        }

    }
   
}
