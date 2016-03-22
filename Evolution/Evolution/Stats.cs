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

        public enum Movement
        {
            None = 1,
            Slither = 2,
            Crawl = 3,
            WalkProne = 4,
            WalkUpright = 5
        };

        /**These variables are calculated from other variables on initialization**/
        //Calculated based on body/fat mass, hunger/thirst levels, and Injury
        private double _baseHealth;
        //Used to identify if entities are of the same species.  Need to consider how to determine this...
        //Calculated by Health, Injury, Aggression, and Sociality
        private double _baseReproductivity;

        /**These variables are generated randomly on initialization**/
        //Sum of body and fat mass
        private double _weight;
        private double _height;
        private double _bodyFatPercent;
        //Affected slowly from increase/decrease in hunger
        private double _bodyMass;
        //Affected quickly from increase/decrease in hunger
        private double _fatMass;
        //Affects odds of fighting, and of winning a fight. Affected by health and injury
        private double _baseAggression;
        //Likeliness to group up with same species of Entities
        private double _baseSociality;
        //Affects odds of surviving a fight
        private double _defense;
        //Affects odds of winning a fight
        private double _attack;
        private double _mobility;

        public Stats()
        {
            GenerateRandomStats();
        }

        public Stats(double weight, double height, double bodyMass, double fatMass, double baseHealth,
            double baseAggression, double baseSociality, double baseReproductivity, double defense, double attack,
            double mobility, double bodyFatPercent)
        {
            _weight = weight;
            _height = height;
            _bodyMass = bodyMass;
            _fatMass = fatMass;
            _baseHealth = baseHealth;
            _baseAggression = baseAggression;
            _baseSociality = baseSociality;
            _baseReproductivity = baseReproductivity;
            _defense = defense;
            _attack = attack;
            _mobility = mobility;
            _bodyFatPercent = bodyFatPercent;
        }

        private void GenerateRandomStats()
        {
            _weight = GenerateWeight();
            _height = GenerateHeight();
            _bodyMass = GenerateBodyMass();
            _fatMass = GenerateFatMass();
            _baseAggression = GenerateBaseAggression();
            _baseSociality = GenerateBaseSociality();
            _attack = GenerateAttack();
            _mobility = GenerateMobility();
            _defense = GenerateDefense();
        }

        private double GenerateWeight()
        {
            return rand.Next((int) Globals.MinWeight, (int) Globals.MaxWeight);
        }

        private double GenerateHeight()
        {
            return rand.Next((int) Globals.MinHeight, (int) Globals.MaxHeight);
        }

        private double GenerateBodyMass()
        {
            if (_bodyFatPercent.Equals(0d))
                _bodyFatPercent = Utilities.GenerateNormalDouble(Globals.MeanBodyFatPercent, Globals.DeviationBodyFatPercent);

            return _weight - (_bodyFatPercent * _weight);
        }

        private double GenerateFatMass()
        {
            if (_bodyFatPercent.Equals(0d))
                _bodyFatPercent = Utilities.GenerateNormalDouble(Globals.MeanBodyFatPercent, Globals.DeviationBodyFatPercent);

            return _bodyFatPercent * _weight;
        }

        private double GenerateBaseAggression()
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
