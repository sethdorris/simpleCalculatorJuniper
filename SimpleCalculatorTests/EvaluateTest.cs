using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class EvaluateTest
    {
        [TestMethod]
        public void EnsureICanCreateAnInstanceOfEvaluateClass()
        {
            Evaluate e = new Evaluate();
            Assert.IsNotNull(e);
        }

        [TestMethod]
        public void EvaluateAdditionExpression()
        {
            Evaluate e = new Evaluate();
            int expected = 4;
            Assert.AreEqual(expected, e.Addition(2, 2));
        }

        [TestMethod]
        public void EvaluateSubtractionExpression()
        {
            Evaluate e = new Evaluate();
            int expected = 4;
            Assert.AreEqual(expected, e.Subtraction(6, 2));
        }

        [TestMethod]
        public void EvaluateMultiplicationExpression()
        {
            Evaluate e = new Evaluate();
            int expected = 10;
            Assert.AreEqual(expected, e.Multiply(2, 5));
        }

        [TestMethod]
        public void EvaluateDivisionExpression()
        {
            Evaluate e = new Evaluate();
            int expected = 2;
            Assert.AreEqual(expected, e.Divide(4, 2));
        }

        [TestMethod]
        public void EvaluateModuloExpression()
        {
            Evaluate e = new Evaluate();
            int expected = 0;
            Assert.AreEqual(expected, e.Modulo(4, 2));
        }

        [TestMethod]
        public void EvaluateEnsureICanEvaluateInputCorrectlyAddition()
        {
            Parse p = new Parse();
            Evaluate e = new Evaluate();
            string input = "4 + 3";
            int num1 = p.getNumberOne(input);
            int num2 = p.getNumberTwo(input);
            string oper = p.getOperator(input);
            int expected = 7;
            Assert.AreEqual(expected, e.ExecuteMethod(num1, num2, oper));
        }
    }
}
