using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_DSDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Custom_Queue<int> Q = new Custom_Queue<int>();
            Q.Enqueue(2);
            Q.Enqueue(3);
            Q.Enqueue(5);
            Node<int> curentNode = Q.Root;
            while(curentNode != null)
            {
                Console.WriteLine(curentNode.value);
                curentNode = curentNode.next;
            }
            Console.WriteLine("-----------------------");


            Custom_Queue<int> Q1 = new Custom_Queue<int>();
            Q1.Enqueue(1);
            Q1.Enqueue(2);
            Q1.Enqueue(3);
            Q1.Enqueue(4);
            Node<int> curentNodeQ1 = Q1.Root;
            while (curentNodeQ1 != null)
            {
                Console.WriteLine(curentNodeQ1.value);
                curentNodeQ1 = curentNodeQ1.next;
            }
            

            Console.WriteLine(Q.Dequeue());
            Console.WriteLine(Q.Dequeue());
            Q.Enqueue(7);
            Console.WriteLine("-----------------------");
            curentNode = Q.Root;
            while (curentNode != null)
            {
                Console.WriteLine(curentNode.value);
                curentNode = curentNode.next;
            }
            





            Console.ReadKey();



        }
    }
}
