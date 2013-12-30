using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderByStringmethods;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IEnumerable<string> tp = Program.AllMethods();

            foreach (var item in tp)
            {
                Assert.IsNotNull(item);
            }
       
        }
    }
}
