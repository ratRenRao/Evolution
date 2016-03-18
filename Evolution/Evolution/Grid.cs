using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution
{
    public class Grid
    {
        private readonly GridUnit[,] _grid;

        private int DimensionSize { get; set; }

        public Grid(int gridUnitCount)
        {
            DimensionSize = (int)Math.Pow(gridUnitCount, .5);
            _grid = new GridUnit[DimensionSize, DimensionSize];
        }

        public GridUnit GetUnitAt(int x, int y)
        {
            return _grid[y, x];
        }

    }
}
