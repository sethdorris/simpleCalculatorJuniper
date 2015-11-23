using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class ParseTest
    {
        [TestMethod]
        public void ParseEnsureICanCreateAnInstance()
        {
            Parse p = new Parse();
            Assert.IsNotNull(p);
        }

        [TestMethod]
        public void ParseEnsureICanGetAdditionOperator()
        {
            Parse p = new Parse();
            string input = "2 + 2";
            Assert.AreEqual("+", p.getOperator(input));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ParseEnsureICanCaptureBadInputDoubleOperator()
        {
            Parse p = new Parse();
            string input = "2 ++ 2";
            p.getOperator(input);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ParseEnsureICanCaptureBadInputNegativeSpaceNumber()
        {
            Parse p = new Parse();
            string input = "2+- 3";
            p.getOperator(input);
        }

        [TestMethod]
        public void ParseEnsureICanGetFirstNumber()
        {
            Parse p = new Parse();
            string input = "4 + 7";
            Assert.AreEqual(4, p.getNumberOne(input));
        }

        [TestMethod]
        public void ParseEnsureICanGetSecondNumber()
        {
            Parse p = new Parse();
            string input = "2+1";
            Assert.AreEqual(1, p.getNumberTwo(input));
        }
    }
}
