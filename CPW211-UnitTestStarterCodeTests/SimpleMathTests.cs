using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace CPW211_UnitTestStarterCode.Tests
{

    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Use the DataRow values to test the Add method
            Assert.AreEqual(num1 + num2, SimpleMath.Add(num1, num2));
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Multiply_TwoNumbers_ReturnsProduct(double a, double b)
        {
            // Use a few pairs of values to test the Multiply method
            Assert.AreEqual(a * b, SimpleMath.Multiply(a, b));
        }

        [TestMethod]
        public void Divide_DenominatorZero_ThrowsArgumentException()
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(1, 0));
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod]
        public void Divide_TwoValidNumbers_ReturnsQuotient()
        {
            Assert.AreEqual(5, SimpleMath.Divide(50, 10));
        }

        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        public void Subtract_TwoValidNumbers_ReturnsDifference()
        {
            Assert.AreEqual(20, SimpleMath.Subtract(37, 17));
        }
    }
}