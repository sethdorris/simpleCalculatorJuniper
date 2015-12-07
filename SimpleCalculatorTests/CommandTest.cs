using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
    [TestClass]
    public class CommandTest
    {
        [TestMethod]
        public void CommandEnsureICanCreateAnInstance()
        {
            myStack q = new myStack();
            Assert.IsNotNull(q);
        }

        [TestMethod]
        public void CommandEnsureICanGetReturnFromLastQCommand()
        {
            Parse p = new Parse();
            Evaluate e = new Evaluate();
            string input = "2 + 2";
            int num1 = p.getNumberOne(input);
            int num2 = p.getNumberTwo(input);
            string oper = p.getOperator(input);
            int answer = e.ExecuteMethod(num1, num2, oper);
            string expected = "2 + 2";
            string actual = e.lastExpression();
            Assert.AreEqual(expected, actual);
        }
    }
}
