using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Minesweeper
{
    public class ConsoleInputValidator : InputValidator
    {
        private List<string> CurLine;
        private int n;
        private int m;

        public override bool CheckFirstInputLine(string FirstLine)
        {
            CurLine = Regex.Replace(FirstLine, @"\s+", " ").Trim().Split(' ').ToList();

            if (CurLine.Count != 2)
            {
                Console.WriteLine("The first line of each field should contain only two values.\nPlease reenter the line...");
                return false;
            }

            try
            {
                n = Convert.ToInt32(CurLine[0]);
                m = Convert.ToInt32(CurLine[1]);
            }
            catch (FormatException)
            {
                Console.WriteLine("The first line of each field should contain two integers n and m.\nPlease reenter the line...");
                return false;
            }

            if (n < 0)
            {
                Console.WriteLine("The number of lines (n) should be possitive (or zero for ending input).\nPlease reenter the line...");
                return false;
            }

            if (m < 0)
            {
                Console.WriteLine("The number of columns (m) should be possitive (or zero for ending input).\nPlease reenter the line...");
                return false;
            }

            if (n == 0)
                if (m == 0)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("The number of lines (n) should be possitive.\nPlease reenter the line...");
                    return false;
                }
            else
                if (m == 0)
                {
                    Console.WriteLine("The number of columns (m) should be possitive.\nPlease reenter the line...");
                    return false;
                }

            if (m > 100)
            {
                Console.WriteLine("The number of columns (m) should less then 100.\nPlease reenter the line...");
                return false;
            }

            return true;
        }

        public override bool CheckNonFirstInputLine(string NonFirstLine)
        {
            Regex reg = new Regex(@"[^\.*]");

            if (NonFirstLine.Length != m)
            {
                string text = text = "Based on the user input, the mines line should include exactly " + m + " characters.\nPlease reenter the line...";
                Console.WriteLine(text);
                return false;
            }
            if (reg.IsMatch(NonFirstLine))
            {
                Console.WriteLine("Mines line should include only \"*\" or \".\" characters.\nPlease reenter the line...");
                return false;
            }
            return true;
        }

    }
}
