using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.Tests
{
    [TestClass()]
    public class BasicMathsTests
    {
        BasicMaths maths = new BasicMaths();

        [TestMethod()]
        public void AddTest()
        {
            double result = maths.Add(10.5, 20);
            Assert.AreEqual(result, 30.5);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            double result = maths.Subtract(10, 7);
            Assert.AreEqual(result, 3);
        }

        [TestMethod()]
        public void DivideTest()
        {
            double result = maths.Divide(20, 2);
            Assert.AreEqual(result, 10);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            double result = maths.Multiply(20, 2);
            Assert.AreEqual(result, 40);
        }
    }
}