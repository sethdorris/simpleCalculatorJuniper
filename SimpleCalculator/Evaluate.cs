using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimpleCalculator
{
    public class Evaluate
    {
        public int ExecuteMethod(int num1, int num2, string oper)
        {
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
        public int Addition(int v1, int v2)
        {
            return v1 + v2;
        }

        public int Subtraction(int v1, int v2)
        {
            return v1 - v2;
        }

        public int Multiply(int v1, int v2)
        {
            return v1 * v2;
        }

        public int Divide(int v1, int v2)
        {
            return v1 / v2;
        }

        public int Modulo(int v1, int v2)
        {
            return v1 % v2; 
        }
    }
}
