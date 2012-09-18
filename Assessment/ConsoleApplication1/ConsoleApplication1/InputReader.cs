using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Minesweeper
{
    public class InputReader : IInputReader
    {
        private IMinesMap InputMap;
        private IInputValidator LineValidator;
        private int _status = -1;

        public InputReader()
        {
            LineValidator = null;
            InputMap = null;
        }

        public InputReader(IInputValidator InValidator, ref IMinesMap InHolder)
        {
            LineValidator = InValidator;
            InputMap = InHolder;
        }

        public void Set(IInputValidator InValidator, ref IMinesMap InHolder)
        {
            LineValidator = InValidator;
            InputMap = InHolder;
        }

        public void ReadInput()
        {
            if (LineValidator == null)
                throw new ArgumentNullException("LineValidator may not be null");

            if (InputMap == null)
                throw new ArgumentNullException("InputMap may not be null");

            try
            {
                string InStr;
                List<string> InLine = new List<string>();

                do
                {
                    InStr = Console.ReadLine();
                }
                while ((LineValidator.CheckFirstInputLine(InStr) == false));

                InLine = Regex.Replace(InStr, @"\s+", " ").Trim().Split(' ').ToList();

                try
                {
                    InputMap.n = Convert.ToInt32(InLine[0]);
                    InputMap.m = Convert.ToInt32(InLine[1]);
                }
                catch (FormatException)
                {
                    _status = -1;
                    return;
                }

                try
                {
                   InputMap.map = new List<List<char>>();
                }
                catch
                {
                    _status = -1;
                    return;
                }   

                if ((InputMap.n == 0) && (InputMap.m == 0))
                { 
                    _status = 0; 
                    return;
                }

                int c = 0;
                do
                {
                    InStr = Console.ReadLine().Trim();
                    if (LineValidator.CheckNonFirstInputLine(InStr) == true)
                    {
                        InputMap.map.Add(InStr.ToCharArray().ToList());
                        c = c + 1;
                    }
                }
                while (c < InputMap.n);

                _status = 1;
                return;
            }
            catch
            {
                _status = -1;
                return;
            }
        }

        public int LastStatus
        {
            get
            {
                return _status;
            }
        }
    }
}
