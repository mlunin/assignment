using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public class ConcoleField : IField
    {
        private IMinesMap _fieldMap;

        public IMinesMap FieldMap
        {
            get {return _fieldMap;}
            set {_fieldMap = value;}
        }

        public ConcoleField(IMinesMap FieldMap)
        {
            _fieldMap = FieldMap;
            if (FieldMap == null)
                throw new ArgumentNullException("Mines Map may not be null");
            CountMines();
        }

        private bool CountMines()
        {
            for (int nn = 0; nn < _fieldMap.n; nn++)
            {
                for (int mm = 0; mm < _fieldMap.m; mm++)
                {
                    if (!(_fieldMap.map[nn][mm].Equals('*')))
                   _fieldMap.map[nn][mm] = ((CountNeighbors(nn, mm)).ToString().ToCharArray())[0];
                }
            }
            return true;
        }

        public int CountNeighbors(int x, int y)
        {
            int res = 0;
              for (int nn = x - 1; nn <= x + 1; nn ++)
                for (int mm = y - 1; mm <= y + 1; mm ++)
                    if ((nn < 0) || (nn >= _fieldMap.n) || (mm < 0) || (mm >= _fieldMap.m) || ((nn == x) && (mm == y))) continue;
                 else
                        if (_fieldMap.map[nn][mm].Equals('*'))
                         res = res + 1;
              return res;
        }
    }
}
