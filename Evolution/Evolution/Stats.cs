using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution
{
    class Stats
    {
        //Used to identify if entities are of the same species.  Need to consider how to determine this...
        private double SpeciesNumber { get; set; }
        //Sum of body and fat mass
        private double Weight { get; set; }
        //Affected slowly from increase/decrease in hunger
        private double BodyMass { get; set; }
        //Affected quickly from increase/decrease in hunger
        private double FatMass { get; set; }
        //Calculated based on body/fat mass, hunger/thirst levels, and Injury
        private double Health { get; set; }
        private double Injury { get; set; }
        //Affects odds of fighting, and of winning a fight
        private double Aggression { get; set; }
        //Likeliness to group up with same species of Entities
        private double Sociality { get; set; }
        //Calculated by Health, Injury, Aggression, and Sociality
        private double Reproductivity { get; set; }
        //Affects odds of surviving a fight
        private double Defense { get; set; }
        //Affects odds of winning a fight
        private double Attack { get; set; }
    }
}
