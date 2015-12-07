using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
   public class myStack
    {
        public string lastq { get; set; }
        public string last { get; set; }
        public myStack()
        {

        }
        public myStack(int num1, int num2, string oper)
        {
            lastq = num1.ToString() + " " + oper + " " + num2.ToString();
        }
    }
}
