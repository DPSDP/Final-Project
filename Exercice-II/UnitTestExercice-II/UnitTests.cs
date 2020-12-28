using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercice_II
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestRangeListByName()
        {
            List<string> L1 = new List<string>() { "Dupont", "Durant", "Abali", "Misiro" };
            List<string> L2 = Program.RangeListByName(L1);
            List<string> L3 = new List<string>() { "Abali", "Dupont", "Durant", "Misiro"};
            CollectionAssert.AreEquivalent(L2,L3);
        }
    }
}
