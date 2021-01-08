using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projet_Final_DSDP_EX3
{
    public class Board
    {
        public List<Player> _Players { get;  }
        public int _currentplayerNum { get; set; }
        
        Observer_Dices O_Dice = new Observer_Dices();

        public Board(List<string> PlayersNames)
        {
            _Players = new List<Player>();
            foreach(string name in PlayersNames)
            {
                Player p = new Player(name);
                _Players.Add(p);
            }
            Dices.Attach(O_Dice);
            _currentplayerNum = 0;
        }

        public void PlayerTurn()
        {
            Player currentplayer = _Players[_currentplayerNum];
            currentplayer.Play();
            _currentplayerNum = (_currentplayerNum +1) % _Players.Count();
            this.Notify();

        }


        public void Notify()
        {
            O_Dice.UpdatePlayerChange();
        }
        static void Main(string[] args)
        {
            

            Console.ReadKey();
        }

    }
    
}
