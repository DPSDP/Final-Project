using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_DSDP_EX3
{
    class Observer_JailOrNot: IObserver
    {
        public void Update(Object p)
        {
            Player pl=p as Player;
            if (pl == null)
            { 
                throw new ArgumentException("p isn't a Player");
            }
        
            int numPos = pl.pos.numPos;
            if (numPos==30)
            {
                pl.pos.numPos = 10;
                pl.Injail = true;
                
            }

                

        }

    }
}
