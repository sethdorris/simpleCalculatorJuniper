using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Parse p = new Parse();
            Evaluate e = new Evaluate();
            bool run = true;

            while (run)
            {
                Console.WriteLine(userName + " Define your mathematical operation");
                string input = Console.ReadLine();
                if (input.ToUpper() == "LASTQ")
                {
                    Console.WriteLine(e.lastExpression());
                    run = false;
                    break;
                }
                string oper = p.getOperator(input);
                int num1 = p.getNumberOne(input);
                int num2 = p.getNumberTwo(input);
                int answer = e.ExecuteMethod(num1, num2, oper);
                Console.WriteLine("The answer to your operation is: " + answer);
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
