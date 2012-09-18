using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public abstract class InputValidator : IInputValidator
    {
        public abstract bool CheckFirstInputLine(string FirstLine);
        public abstract bool CheckNonFirstInputLine(string NonFirstLine);
    }
}
