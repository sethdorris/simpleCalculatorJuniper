using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCalculator;


namespace SimpleCalculator
{
    public class Evaluate
    {
        private myStack s = new myStack();
        public int ExecuteMethod(int num1, int num2, string oper)
        {
            s.lastq = num1.ToString() + " " + oper + " " + num2.ToString();
            switch (oper)
            {
                case "+":
                   return Addition(num1, num2);
                case "-":
                   return Subtraction(num1, num2);
                case "*":
                   return Multiply(num1, num2);
                case "/":
                   return Divide(num1, num2);
                case "%":
                   return Modulo(num1, num2);
                default:
                    break;
            }
            throw new InvalidOperationException();
        }

        private int Modulo(int num1, int num2)
        {
            return num1 % num2;
        }

        private int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        private int Multiply(int num1, int num2)
        {

            return num1 * num2;
        }

        private int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public string lastExpression()
        {
            return s.lastq;
        }
    }
}
