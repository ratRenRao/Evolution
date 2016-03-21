using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution
{
    public static class Globals
    {
        public static int NextEntityId;

        //Stats generation constants
        public const double MinWeight = 1d;
        public const double MaxWeight = 500d;
        public const double MinHeight = 1d;
        public const double MaxHeight = 120d;
        public const double MinBodyFatPercent = 5d;
        public const double MaxBodyFatPercent = 30d;
    }
}
