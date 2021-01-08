using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projet_Final_DSDP_EX3;
using System.Collections.Generic;

namespace Projet_Final_DSDP_EX3
{
    [TestClass]
    public class TestBoard
    {
        [TestMethod]
        public void TestBoardPlayersCreation()
        {
            List<string> PlayersNames = new List<string>() { "Tom", "Emma", "Sarah" };
            Board board = new Board(PlayersNames);

            Assert.AreEqual(3, board._Players.Count);
            Assert.AreEqual("Tom", board._Players[0].alias);
            Assert.AreEqual("Emma", board._Players[1].alias);
            Assert.AreEqual("Sarah", board._Players[2].alias);
        }

    }
}
