using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DEV_3.tests
{
    [TestClass]
    public class TranslateTests
    {
        [TestMethod]
        public void Test_TranslateString_Latin()
        {
            //arrange
            string str = "Я смог";
            string expected = "Ya smog";
            //act
            Translate a = new Translate();
            
            string actual= a.TranslateString(str);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_TranslateString()
        {
            //arrange
            string str = "";
            string expected = "";
            //act
            Translate a = new Translate();

            string actual = a.TranslateString(str);
            Assert.AreEqual(expected, actual);
        }
    }
}
