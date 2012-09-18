using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public interface IInputValidator
    {
        bool CheckFirstInputLine(string FirstLine);
        bool CheckNonFirstInputLine(string NonFirstLine);
    }
}
