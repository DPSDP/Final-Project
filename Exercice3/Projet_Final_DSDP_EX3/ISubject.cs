using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_DSDP_EX3
{
    public interface ISubject
    {
        void Notify();
        void Attach(IObserver observer);

       
        

    }
}
