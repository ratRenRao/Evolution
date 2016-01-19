using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution
{
    public class Grid
    {
        private GridUnit[,] grid { get; set; }
        private int dimensionSize { get; set; }

        public Grid(int gridUnitCount)
        {
            dimensionSize = (int)Math.Pow(gridUnitCount, .5);
            grid = new GridUnit[dimensionSize, dimensionSize];
        }

        public GridUnit GetUnitAt(int x, int y)
        {
            return grid[y, x];
        }

    }
}
