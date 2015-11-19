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
            if (AreSpaces(input))
            {
                string inputWithOutSpaces = removeSpaces(input);
            }
            return "+";
        }

        public int getNumberOne(string input)
        {
            int num1;
            string[] inputArray = Regex.Split(input, @"([-+*/])");
            int.TryParse(inputArray[0], out num1);
            return num1;
        }

        public int getNumberTwo(string input)
        {
            int num2;
            string[] inputArray = Regex.Split(input, @"([-+*/])");
            int.TryParse(inputArray[2], out num2);
            return num2;
        }

        public string[] getInputStringArray(string input)
        {
            string[] inputArray = Regex.Split(input, @"([-+*/])");
            return inputArray;
        }

        public string removeSpaces(string input)
        {
            string[] noSpaces = input.Split(' ');
            input = String.Join("", noSpaces);
            return input;
        }

        public bool AreSpaces(string input)
        {
            int indexOfSpaces = input.IndexOf(" ");
            if (indexOfSpaces > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
