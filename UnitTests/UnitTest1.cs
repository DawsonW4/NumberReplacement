using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestLib;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_PrintNumbers()
        {
            int lowerRange = 1;
            int upperRange = 5;
            Dictionary<int, string> divisibleList = new Dictionary<int,string>();
            string[] testStringList = new string[5];

            divisibleList.Add(2, "Test1");
            divisibleList.Add(4, "Test2");
            divisibleList.Add(5, "Test3");

            testStringList[0] = "1";
            testStringList[1] = "Test1";
            testStringList[2] = "3";
            testStringList[3] = "Test1Test2";
            testStringList[4] = "Test3";


            string[] returnedStringList = PrintClass.PrintNumbers(lowerRange, upperRange, divisibleList);

            CollectionAssert.AreEqual(testStringList, returnedStringList);
        }

        [TestMethod]
        public void Test_BuildOutputString_noneDivisble()
        {
            int divNum = 2;
            Dictionary<int, string> divisibleList = new Dictionary<int, string>();

            divisibleList.Add(3, "Test");

            string testString = PrintClass.BuildOutputString(divNum, divisibleList);

            Assert.AreEqual(testString, "2");
        }

        [TestMethod]
        public void Test_BuildOutputString_isDivisbleOnce()
        {
            int divNum = 2;
            Dictionary<int, string> divisibleList = new Dictionary<int, string>();

            divisibleList.Add(2, "Test");

            string testString = PrintClass.BuildOutputString(divNum, divisibleList);

            Assert.AreEqual(testString, "Test");
        }

        [TestMethod]
        public void Test_BuildOutputString_isDivisbleMultiple()
        {
            int divNum = 2;
            Dictionary<int, string> divisibleList = new Dictionary<int, string>();

            divisibleList.Add(1, "Test1");
            divisibleList.Add(2, "Test2");

            string testString = PrintClass.BuildOutputString(divNum, divisibleList);

            Assert.AreEqual(testString, "Test1Test2");
        }
    }
}
