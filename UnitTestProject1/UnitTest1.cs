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
            List<ParamSchema> testList = new List<ParamSchema>();
            testList.Add(new ParamSchema() {Flag = "l", Type = typeof(bool), Default=true });

           // string testString = "-l -p 8080 -d /usr/logs";
            string testString = "-l true";

            foreach (var item in new Parser().GetParam(testString))
            {
                     Assert.IsInstanceOfType(item.Value, testList.FirstOrDefault(a => a.Flag==item.Flag)?.Type);
            }
        }
    }
}
