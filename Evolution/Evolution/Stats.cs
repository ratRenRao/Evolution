using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution
{
    class Stats
    {
        Random rand = new Random();

        /**These variables are calculated from other variables on initialization**/
        //Calculated based on body/fat mass, hunger/thirst levels, and Injury
        public readonly double BaseHealth;
        //Used to identify if entities are of the same species.  Need to consider how to determine this...
        //Calculated by Health, Injury, Aggression, and Sociality
        public readonly double BaseReproductivity;

        /**These variables are generated randomly on initialization**/
        //Sum of body and fat mass
        public readonly double Weight;
        public readonly double Height;
        //Affects odds of fighting, and of winning a fight. Affected by health and injury
        public readonly double BaseAggression;
        //Likeliness to group up with same species of Entities
        public readonly double BaseSociality;
        //Affects odds of surviving a fight
        public readonly double Defense;
        //Affects odds of winning a fight
        public readonly double Attack;
        public readonly double Mobility;

        public Stats()
        {
            Weight = GenerateWeight();
            Height = GenerateHeight();
            BaseHealth = GenerateBaseHealth();
            BaseAggression = GenerateBaseAggression();
            BaseSociality = GenerateBaseSociality();
            BaseReproductivity = GenerateBaseReproductivity();
            Attack = GenerateAttack();
            Mobility = GenerateMobility();
            Defense = GenerateDefense();
        }

        public Stats(double weight, double height, double baseHealth,
            double baseAggression, double baseSociality, double baseReproductivity, double defense, double attack,
            double mobility)
        {
            Weight = weight;
            Height = height;
            BaseHealth = baseHealth;
            BaseAggression = baseAggression;
            BaseSociality = baseSociality;
            BaseReproductivity = baseReproductivity;
            Defense = defense;
            Attack = attack;
            Mobility = mobility;
        }

        private double GenerateWeight()
        {
            return rand.Next((int) Globals.MinWeight, (int) Globals.MaxWeight);
        }

        private double GenerateHeight()
        {
            return rand.Next((int) Globals.MinHeight, (int) Globals.MaxHeight);
        }

        private double GenerateBaseAggression()
        {
            return Utilities.GenerateNormalDouble(Globals.MeanAggression, Globals.DeviationAgression);
        }

        private double GenerateBaseHealth()
        {
            return Utilities.GenerateNormalDouble(Globals.MeanHealth, Globals.DeviationHealth);
        }

        private double GenerateBaseReproductivity()
        {
            return Utilities.GenerateNormalDouble(Globals.MeanAggression, Globals.DeviationAgression);
        }

        private double GenerateBaseSociality()
        {
            return Utilities.GenerateNormalDouble(Globals.MeanSociality, Globals.DeviationSociality);
        }

        private double GenerateDefense()
        {
            return Utilities.GenerateNormalDouble(Globals.MeanDefense, Globals.DeviationDefense);
        }

        private double GenerateAttack()
        {
            return Utilities.GenerateNormalDouble(Globals.MeanAttack, Globals.DeviationAttack);
        }

        private double GenerateMobility()
        {
            return Utilities.GenerateNormalDouble(Globals.MeanMobility, Globals.DeviationMobility);
        }
    }
}
