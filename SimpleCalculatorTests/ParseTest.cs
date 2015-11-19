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
        public void ParseDetectingIfThereIsSpaces()
        {
            Parse p = new Parse();
            string input = "2 + 2";
            Assert.IsTrue(p.AreSpaces(input));
        }

        [TestMethod]
        public void ParseThereAreNoSpaces()
        {
            Parse p = new Parse();
            string input = "2+2";
            Assert.IsFalse(p.AreSpaces(input));
        }

        [TestMethod]
        public void ParseEnsureICanGetFirstNumber()
        {
            Parse p = new Parse();
            string input = "2+3";
            Assert.AreEqual(2, p.getNumberOne(input));
        }

        [TestMethod]
        public void ParseTestSplitInputStringOnOperatorsWithoutSpaces()
        {
            Parse p = new Parse();
            string input = "5+4";
            string[] expected = { "5", "+", "4" };
            CollectionAssert.AreEqual(expected, p.getInputStringArray(input));
        }

        [TestMethod]
        public void ParseEnsureICanGetRidOfSpaces()
        {
            Parse p = new Parse();
            string input = "2 + 2";
            Assert.AreEqual("2+2", p.removeSpaces(input));
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
