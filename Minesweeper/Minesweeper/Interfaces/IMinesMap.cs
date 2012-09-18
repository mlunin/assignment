using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public interface IMinesMap
    {
        int n 
        {
            get;
            set;
        }

        int m 
        {
            get;
            set;
        }

        List<List<char>> map
        {
            get;
            set;
        }
    }
}
