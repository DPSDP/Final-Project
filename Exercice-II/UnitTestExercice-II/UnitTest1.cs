using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace Exercice_II
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAppendFirstRowToNewDataframe()
        {
            ArrayList firstRow = new ArrayList() { "Citadine", "Renault", "Clio", 2015 };
            Dataframe dataframe = new Dataframe(firstRow);
            Assert.AreEqual(dataframe.ColumnsTypes[0], "String");
            Assert.AreEqual(dataframe.ColumnsTypes[1], "String");
            Assert.AreEqual(dataframe.ColumnsTypes[2], "String");
            Assert.AreEqual(dataframe.ColumnsTypes[3], "Int32");

            CollectionAssert.AreEquivalent(firstRow, dataframe.getIndex(0));
        }

        [TestMethod]
        public void TestAppendRowToDataframe()
        {
            // Initialization
            ArrayList firstRow = new ArrayList() { "Citadine", "Renault", "Clio", 2015 };
            Dataframe dataframe = new Dataframe(firstRow);


            ArrayList individuB = new ArrayList() { "Citadine", "Citoën", "C3", 2019 };
            dataframe.Add(individuB);
            CollectionAssert.AreEquivalent(individuB, dataframe.getIndex(1));
        }
    }
}
