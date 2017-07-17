using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myLib;

namespace myLibraryUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void ArrayStringWithSpaceTest()
        {
            ApplicationCodeClass target = new ApplicationCodeClass();
            string[] stringArray = null;
            string expected = string.Empty;
            string actual;

            actual = target.combineArrayStringWithSpace(stringArray);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PositiveScenario_ArrayStringWithSpaceTest()
        {

            string expected = "Life in Colors";
            string[] actualStringArray = new string[] { "Life", "in", "Colors" };

            ApplicationCodeClass target = new ApplicationCodeClass();


            string actual = target.combineArrayStringWithSpace(actualStringArray);
            Assert.AreEqual(expected, actual);
        }
    }
}
