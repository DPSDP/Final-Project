using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_DSDP_EX3
{
   public class Position
    {// in this class there are 40 circular positions (0-39) meaning that once the player reaches 39 it goes all the way back to 0 
        int numPos { get; set; }//position number
        public Position()
        {
            this.numPos = 0;
        }
        public Position(int numPos)
        {
            this.numPos = numPos;
        }

        /// <summary>
        /// JailOrNot
        /// </summary>
        /// <param name="p">Player that we want to know if they're in Jail or Not</param>
        /// <returns></returns>
        public static bool  JailOrNot(Player p) //Position pos 
        {
            bool res;
            if (Position.MoveForward(p) == 30 || Position.MoveForward(p) == 10)
            {
                res = true;

            }
            else
            {
                res = false;
            }

            return res;
        }
        /// <summary>
        /// MoveForward
        /// </summary>
        /// <param name="p"> player that is moving forward</param>
        /// <param name="d">the dices that will be thrown</param>
        public static int MoveForward(Player p)
        {
            Dices d=new Dices();
            if (p.pos.numPos+d.RollingResult()>=40)
            {
                p.pos.numPos=p.pos.numPos + d.RollingResult()-40;
            }
            else
            {
                p.pos.numPos= p.pos.numPos + d.RollingResult();

            }
            return p.pos.numPos;
        }












    }
}
