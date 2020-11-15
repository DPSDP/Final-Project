using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Final_DSDP
{
    class Custom_Queue<T>
    {
        public Node<T> Root { get; set; }
        public Node<T> LastNode { get; set; }

        public Custom_Queue()
        {
            this.Root = null;
            this.LastNode = null;

        }
        public Custom_Queue(T elt)
        {
            Node<T> node = new Node<T>(elt);
            this.Root = node;
        }
        /// <summary>
        /// Enqueue method
        /// </summary>
        /// This method's role is to enqueue the element to the  current custom queue 
        /// <param name="elt">the element to enqueue on the custom queue</param>
        public void Enqueue(T elt)
        {
            if (this.Root != null)
            {
                Node<T> node = new Node<T>(elt);
                this.LastNode.next = node;
                this.LastNode = this.LastNode.next;
            }
            else
            {
                Node<T> node = new Node<T>(elt);
                this.Root = node;
                this.LastNode = this.Root;
                
            }

        }


        
    }
}
