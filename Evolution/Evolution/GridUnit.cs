using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution
{
    public class GridUnit
    {
        public int Food { get; set; }
        public int Water { get; set; }
        //Difficulty of travel
        public double TraversalIndex { get; set; }
    }
}
