using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_DSDP_EX3
{
    public class Dices
    {
        private static readonly Dices instance = new Dices();
        private static Dice _Dice1 { get; set; }
        private static Dice _Dice2 { get; set; }
        private static (int,int) _res { get; set; }
        private static List<IObserver> _observers = new List<IObserver>();
        //Implementation of singleton design
        static Dices()
        {

        }
        private Dices()
        {

        }
        public static Dices Instance
        {
            get
            {
                return instance;
            }
        }

        public static void Roll(Player p)
        {
            Dice Dice1 = new Dice();
            Dice Dice2 = new Dice();
            int r1 = Dice1.RollDice();
            int r2 = Dice2.RollDice();


            if (r1 == r2)
            {
                Instance.Notify(p);
                int newPosition = (p.pos.numPos + r1 + r2) % 40;
                if (!p.Injail && newPosition != 30)
                {
                    //we did this because the observer can send the player to prison, so it's to avoid getting out of it
                    p.pos.numPos = newPosition;
                    Dices.Roll(p);
                }
                else if(newPosition == 30)
                {
                    p.pos.numPos = newPosition;
                }
            }
            else
            {
                p.pos.numPos = (p.pos.numPos + r1 + r2) % 40;
            }
            
        }
        public static void Attach(IObserver observer)
        {
            
            _observers.Add(observer);
        }


        private void Notify(Player p)
        {
           foreach(IObserver o in _observers)
            {
                o.Update(p);
            }
        }

    }
}
