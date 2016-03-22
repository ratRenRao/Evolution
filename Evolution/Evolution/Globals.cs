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

        public const double MeanBodyFatPercent = 15d;
        public const double DeviationBodyFatPercent = 3d;

        public const double MeanAggression = 50d;
        public const double DeviationAgression = 10d;

        public const double MeanSociality = 50d;
        public const double DeviationSociality = 15d;

        public const double MeanDefense = 40d;
        public const double DeviationDefense = 15d;

        public const double MeanAttack = 40d;
        public const double DeviationAttack= 15d;

        public const double MeanMobility = 50d;
        public const double DeviationMobility = 15d;

    }
}
