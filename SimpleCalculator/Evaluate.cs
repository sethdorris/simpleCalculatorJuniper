using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleCalculator
{
    public class Evaluate
    {
        public int ExecuteMethod(string num1, string num2, string oper)
        {
            switch (oper)
            {
                case "+":
             //      return Addition(num1, num2);
                case "-":
               //     return Subtraction(num1, num2);
                case "*":
                 //   return Multiply(num1, num2);
                case "/":
                   // return Divide(num1, num2);
                case "%":
                   // return Modulo(num1, num2);
                default:
                    break;
            }
            throw new InvalidOperationException();
        }
    }
}
