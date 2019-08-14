using System;
using System.Collections.Generic;
using Args_tdd_sample;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Linq.Expressions;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           string testString = "-l -p 8080 -d /usr/logs";
            //string testString = "-l true";

            Assert.AreEqual(true,new Parser(testString).GetParam("l").Value);
            Assert.AreEqual(8080, new Parser(testString).GetParam("p").Value);
            Assert.AreEqual("/usr/logs", new Parser(testString).GetParam("d").Value);
           
        }
    }
}
