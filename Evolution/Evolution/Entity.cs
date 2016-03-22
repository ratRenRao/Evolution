using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Evolution
{
    class Entity
    {
        private enum GenderType
        {
            Male,
            Female
        };

        public readonly int Id;
        //Calculated from weight and mobility
        private double RequiredFood { get; set; }
        //Calculated from weight and mobility
        private double FoodConsumptionRate { get; set; }
        private double RequiredWater { get; set; }
        private double WaterConsumptionRate { get; set; }
        private double Hunger { get; set; }
        private double Thirst { get; set; }
        private double Aggression { get; set; }
        private double Sociality { get; set; }
        //Calculated based on body/fat mass, hunger/thirst levels, and Injury
        private double Health { get; set; }
        private double Injury { get; set; }
        //Used to identify if entities are of the same species.  Need to consider how to determine this...
        private double SpeciesNumber { get; set; }
        private GenderType Gender { get; set; }
        //Calculated by Health, Injury, Aggression, and Sociality
        private double Reproductivity { get; set; }
        //Calculated from body + fat mass
        private double EnergyExpenditure { get; set; }

        private double _bodyFatPercent;
        //Affected slowly from increase/decrease in hunger
        private double _bodyMass;
        //Affected quickly from increase/decrease in hunger
        private double _fatMass;
        private Stats Stats { get; set; }
        private GridUnit Location { get; set; }

        public Entity()
        {
            Id = Globals.NextEntityId++;
            CreateRandomStats();
            CalculateTraits();
        }

        public Entity( double weight, double height, double baseHealth, double baseAggression, double baseSociality, double baseReproductivity, double defense, double attack,
            double mobility)
        {
            Id = Globals.NextEntityId++;
            CreateSpecificStats(weight, height, baseHealth, baseAggression, baseSociality, baseReproductivity, defense, attack, mobility);
            CalculateTraits();
        }

        private void CreateRandomStats()
        {
            Stats = new Stats(); 
        }

        private void CreateSpecificStats(double weight, double height, double baseHealth, double baseAggression, double baseSociality, double baseReproductivity, double defense, double attack, double mobility)
        {
            Stats = new Stats(weight, height, baseHealth, baseAggression, baseSociality, baseReproductivity, defense, attack, mobility); 
        }

        private void CalculateTraits()
        {
            Gender = (GenderType) new Random().Next(0, 1);
        }

        private double CalculateSpeciesNumber()
        {
            
        }

        private double CalculateHealth()
        {

        }

        private double CalculateInjury()
        {

        }

        private double CalculateReproductivity()
        {


        }

        private double CalculateBodyMass()
        {
            if (_bodyFatPercent.Equals(0d))
                _bodyFatPercent = Utilities.GenerateNormalDouble(Globals.MeanBodyFatPercent, Globals.DeviationBodyFatPercent);

            return Stats.Weight - (_bodyFatPercent * Stats.Weight);
        }

        private double GenerateFatMass()
        {
            if (_bodyFatPercent.Equals(0d))
                _bodyFatPercent = Utilities.GenerateNormalDouble(Globals.MeanBodyFatPercent, Globals.DeviationBodyFatPercent);

            return _bodyFatPercent * _weight;
        }
    }
}
