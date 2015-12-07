using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class EvaluateTest
    {
        [TestMethod]
        public void EvaluateTestEnsureICanAdd()
        {
            Evaluate e = new Evaluate();
            Parse p = new Parse();
            string input = "2 + 2";
            int num1 = p.getNumberOne(input);
            int num2 = p.getNumberTwo(input);
            string oper = p.getOperator(input);
            int expected = 4;
            Assert.AreEqual(expected, e.ExecuteMethod(num1, num2, oper));
        }

        [TestMethod]
        public void EvaluateTestEnsureICanSubtract()
        {
            Evaluate e = new Evaluate();
            Parse p = new Parse();
            string input = "2 - 2";
            int num1 = p.getNumberOne(input);
            int num2 = p.getNumberTwo(input);
            string oper = p.getOperator(input);
            int expected = 0;
            Assert.AreEqual(expected, e.ExecuteMethod(num1, num2, oper));
        }

        [TestMethod]
        public void EvaluateTestEnsureICanMultiply()
        {
            Evaluate e = new Evaluate();
            Parse p = new Parse();
            string input = "2 * 2";
            int num1 = p.getNumberOne(input);
            int num2 = p.getNumberTwo(input);
            string oper = p.getOperator(input);
            int expected = 4;
            Assert.AreEqual(expected, e.ExecuteMethod(num1, num2, oper));
        }

        [TestMethod]
        public void EvaluateTestEnsureICanDivide()
        {
            Evaluate e = new Evaluate();
            Parse p = new Parse();
            string input = "4 / 2";
            int num1 = p.getNumberOne(input);
            int num2 = p.getNumberTwo(input);
            string oper = p.getOperator(input);
            int expected = 2;
            Assert.AreEqual(expected, e.ExecuteMethod(num1, num2, oper));
        }

        [TestMethod]
        public void EvaluateTestEnsureICanModulo()
        {
            Evaluate e = new Evaluate();
            Parse p = new Parse();
            string input = "2 % 2";
            int num1 = p.getNumberOne(input);
            int num2 = p.getNumberTwo(input);
            string oper = p.getOperator(input);
            int expected = 0;
            Assert.AreEqual(expected, e.ExecuteMethod(num1, num2, oper));
        }
    }
}
