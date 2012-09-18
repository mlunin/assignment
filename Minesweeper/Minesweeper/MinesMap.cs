using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public class MinesMap : IMinesMap
    {
        private int _n;
        private int _m;
        private List<List<char>> _map;

        public int  n
        {
	        get 
	        { 
		       return _n;
	        }

	        set 
	        { 
		        _n = value;
	        }
        }

        public int  m
        {
	        get 
	        { 
		        return _m;
	        }

	        set 
	        { 
		       _m = value;
	        }
        }

        public List<List<char>> map
        {
	        get 
	        {
                return _map;
	        }

	        set 
	        { 
		       _map = value;
	        }
        }
    }  
}
