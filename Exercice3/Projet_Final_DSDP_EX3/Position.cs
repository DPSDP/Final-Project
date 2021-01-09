using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_DSDP_EX3
{
   public class Position:ISubject
    {// in this class there are 40 circular positions (0-39) meaning that once the player reaches 39 it goes all the way back to 0 
        public int numPos { get; set; }//position number
        private static List<IObserver> _observers = new List<IObserver>();
        public Position()
        {
            this.numPos = 0;
        }
        public Position(int numPos)
        {
            this.numPos = numPos;
            Observer_JailOrNot  O_JailOrNot=new Observer_JailOrNot();
            this.Attach(O_JailOrNot);
        }
        
       

        // The subscription management methods.
        public void Attach(IObserver observer)
        {

            _observers.Add(observer);
        }

       
        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(this.numPos);
            }
        }

        








    }
}
