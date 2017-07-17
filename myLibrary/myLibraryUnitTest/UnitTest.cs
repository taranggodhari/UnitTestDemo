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

            string expected = "Today is the wonderful day of my life";
            string[] actualStringArray = new string[] { "Today", "is", "the", "wonderful", "day", "of", "my", "life" };

            ApplicationCodeClass target = new ApplicationCodeClass();


            string actual = target.combineArrayStringWithSpace(actualStringArray);
            Assert.AreEqual(expected, actual);
        }
    }
}
