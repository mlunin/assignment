using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public interface IField
    {
        int CountNeighbors(int x, int y);
    }
}
