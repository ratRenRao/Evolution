using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution
{
    internal class Utilities
    {
        private static readonly Random Rand = new Random();

        public static double GenerateNormalDouble(double mean, double standartDeviation)
        {
            var u1 = Rand.NextDouble(); //these are uniform(0,1) random doubles
            var u2 = Rand.NextDouble();
            var randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
            return mean+ standartDeviation * randStdNormal; //random normal(mean,stdDev^2)
        }
    }
}
