using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public interface IInputReader
    {
        void ReadInput();
        int LastStatus 
        {
            get;
        }
    }
}
