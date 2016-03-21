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
        private double _health;
        private double _injury;
        //Used to identify if entities are of the same species.  Need to consider how to determine this...
        private double _speciesNumber;
        //Calculated by Health, Injury, Aggression, and Sociality
        private double _reproductivity;

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
        private double _aggression;
        //Likeliness to group up with same species of Entities
        private double _sociality;
        //Affects odds of surviving a fight
        private double _defense;
        //Affects odds of winning a fight
        private double _attack;
        private double _mobility;

        public Stats()
        {
            GenerateRandomStats();
        }

        public Stats(double speciesNumber, double weight, double height, double bodyMass, double fatMass, double health,
            double injury, double aggression, double sociality, double reproductivity, double defense, double attack,
            double mobility, double bodyFatPercent)
        {
            _speciesNumber = speciesNumber;
            _weight = weight;
            _height = height;
            _bodyMass = bodyMass;
            _fatMass = fatMass;
            _health = health;
            _injury = injury;
            _aggression = aggression;
            _sociality = sociality;
            _reproductivity = reproductivity;
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
            _aggression = GenerateAggression();
            _sociality = GenerateSociality();
            _attack = GenerateAttack();
            _mobility = GenerateMobility();
            _defense = GenerateDefense();

            _health = CalculateHealth();
            _injury = CalculateInjury();
            _reproductivity = CalculateReproductivity();
            _speciesNumber = CalculateSpeciesNumber();
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
            if (_bodyFatPercent == 0d)
                _bodyFatPercent = rand.Next((int)Globals.MinBodyFatPercent, (int)Globals.MaxBodyFatPercent);

            return _weight - (_bodyFatPercent * _weight);
        }

        private double GenerateFatMass()
        {
            if (_bodyFatPercent == 0d)
                _bodyFatPercent = rand.Next((int)Globals.MinBodyFatPercent, (int)Globals.MaxBodyFatPercent);

            return _bodyFatPercent * _weight;
        }

        private double GenerateAggression()
        {

        }

        private double GenerateSociality()
        {

        }

        private double GenerateDefense()
        {

        }

        private double GenerateAttack()
        {

        }

        private double GenerateMobility()
        {

        }

        private double CalculateHealth()
        {

        }

        private double CalculateInjury()
        {

        }

        private double CalculateSpeciesNumber()
        {

        }

        private double CalculateReproductivity()
        {


        }
    }
}
