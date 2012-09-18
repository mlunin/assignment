using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public class OutputWriter : IOuputWriter
    {
        private IMinesMap OutputMap;
        private int _status = -1; 

        public OutputWriter()
        {
            OutputMap = null;
        }

        public OutputWriter(IMinesMap OutHolder)
        {
            OutputMap = OutHolder;
        }

        public void Set(IMinesMap OutHolder)
        {
            OutputMap = OutHolder;
        }

        public void WriteOutput()
        {
            try
            {
                for (int nn = 0; nn < OutputMap.n; nn++)
                {
                    for (int mm = 0; mm < OutputMap.m; mm++)
                        Console.Write(OutputMap.map[nn][mm]);
                    Console.WriteLine();
                }
                _status = 1;
            }
            catch
            {
                _status = -1;
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
