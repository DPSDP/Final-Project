using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projet_Final_DSDP;
using System;
using System.Collections.Generic;

namespace unit_test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test()
        {
            Custom_Queue<int> Q1 = new Custom_Queue<int>();
            Q1.Enqueue(1);
            Q1.Enqueue(2);
            Q1.Enqueue(3);
            Q1.Enqueue(4);
            Node<int> curentNodeQ1 = Q1.Root;
            int var1 = 1;
            while (curentNodeQ1 != null)
            {
                Assert.AreEqual(curentNodeQ1.value, var1);
                curentNodeQ1 = curentNodeQ1.next;
                var1++;
            }

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Custom Queue empty !")]
        public void TestDequeError()
        {
            Custom_Queue<int> Q1 = new Custom_Queue<int>();
            Q1.Enqueue(1);
            Q1.Dequeue();
            Q1.Dequeue();
           

        }
    }
}
