using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projet_Final_DSDP_EX3;
using System.Collections.Generic;

namespace Projet_Final_DSDP_EX3
{
    [TestClass]
    public class TestPlayer
    {
        [TestMethod]
        public void TestPlayerConstructorWithAliasOnly()
        {
            Player p1 = new Player("Sarah");
            Assert.AreEqual("Sarah", p1.alias);
        }

    }
}
