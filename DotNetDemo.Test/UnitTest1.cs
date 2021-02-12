using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetDemo.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addTestMethod()
        {
            Calculator calculator = new Calculator();
            Assert.AreEqual(2, calculator.add(1, 1));
        }
    }
}
