using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DEV_2.tests
{
    [TestClass]
    public class StringAnalizerTests
    {
        [TestMethod]
        public void Test_MaxOfDifferentSimbols()
        {
            //Arage
            string str = "abccbad";
            int expected = 4;
            //act
            int actual = StringAnalizer.MaxOfDifferentSimbols(str);
            //acert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_MaxOfDifferentSimbols_WhenEmpty()
        {
            //Arage
            string str = "";
            int expected = 0;
            //act
            int actual = StringAnalizer.MaxOfDifferentSimbols(str);
            //acert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_MaxOfIdentialNumbers()
        {
            //Arage
            string str = "abccbad2111";
            int expected = 3;
            //act
            int actual = StringAnalizer.MaxOfIdentialNumbers(str);
            //acert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_MaxOfIdentialNumbers_WhenEmpty()
        {
            //Arage
            string str = "";
            int expected = 0;
            //act
            int actual = StringAnalizer.MaxOfIdentialNumbers(str);
            //acert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_MaxOfLatinSimbols()
        {
            //Arage
            string str = "abccbad";
            int expected = 2;
            //act
            int actual = StringAnalizer.MaxOfIdentialNumbers(str);
            //acert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_MaxOfLatinSimbols_WhenEmpty()
        {
            //Arage
            string str = "abccbad";
            int expected = 2;
            //act
            int actual = StringAnalizer.MaxOfIdentialNumbers(str);
            //acert
            Assert.AreEqual(expected, actual);
        }
    }
}

