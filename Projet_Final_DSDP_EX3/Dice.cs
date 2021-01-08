using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_DSDP_EX3
{
    public class Dice
    {

         static Random numgen = new Random();
         
        
        public int RollDice()
        {
           int  res = numgen.Next(1, 7);
            return res;
        }

    }
}
