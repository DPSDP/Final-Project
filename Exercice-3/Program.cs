using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_DSDP_EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player("player1");

            Console.WriteLine(Position.JailOrNot(p));
          
            Console.ReadKey();
        }
    }
}
