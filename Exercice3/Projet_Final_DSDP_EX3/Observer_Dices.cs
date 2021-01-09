using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_DSDP_EX3
{
    class Observer_Dices:IObserver
    {
        private int _doubleCounter = 0;
        public void Update(Object p)
        {
            _doubleCounter += 1;
            Player pl = p as Player;
            if (pl == null)
            {
                throw new ArgumentException("p isn't a Player");
            }

            if(_doubleCounter == 3)
            {
                pl.goToJail();
            }

        }
        public void UpdatePlayerChange()
        {
            _doubleCounter = 0;
        }
    }
}
