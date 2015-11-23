using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Parse
    {
        public string getOperator(string input)
        {
            Match m = Regex.Match(input, @"^(-?\d+)\s*([\+\-\*\%\/])\s*(-?\d+)");
            if (!m.Success)
            {
                throw new ArgumentException("You should provide a positive or negative interger followed by an operator and then a positive or negative interger");
            }
            return m.Groups[2].Value;
        }

        public int getNumberOne(string input)
        {
            int num1;
            Match m = Regex.Match(input, @"^(-?\d+)\s*([\+\-\*\%\/])\s*(-?\d+)");
            int.TryParse(m.Groups[1].Value, out num1);
            return num1;
        }

        public int getNumberTwo(string input)
        {
            int num2;
            Match m = Regex.Match(input, @"^(-?\d+)\s*([\+\-\*\%\/])\s*(-?\d+)");
            int.TryParse(m.Groups[3].Value, out num2);
            return num2;
        }
    }
}
