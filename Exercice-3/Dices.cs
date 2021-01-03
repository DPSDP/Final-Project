using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_DSDP_EX3
{
    public class Dices
    {
        Dice Dice1 { get; set; }
        Dice Dice2 { get; set; }
        int res { get; set; }
        public Dices()
        {
           this.res=this.RollingResult() ;
        }
        public  int RollingResult()
        {
            return Dice1.RollDice()+ Dice2.RollDice();

        }
    }
}
