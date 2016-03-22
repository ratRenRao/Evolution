using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
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

        private double BodyFatPercent { get; set; }
        //Affected slowly from increase/decrease in hunger
        private double BodyMass { get; set; }
        //Affected quickly from increase/decrease in hunger
        private double FatMass { get; set; }
        private DnaImmitator DnaImmitator;
        private Stats Stats { get; set; }
        private GridUnit Location { get; set; }

        public Entity()
        {
            Id = Globals.NextEntityId++;
            CreateRandomStats();
            CalculateTraits();
            GenerateDna();
        }

        public Entity( double weight, double height, double baseHealth, double baseAggression, double baseSociality, double baseReproductivity, double defense, double attack,
            double mobility)
        {
            Id = Globals.NextEntityId++;
            CreateSpecificStats(weight, height, baseHealth, baseAggression, baseSociality, baseReproductivity, defense, attack, mobility);
            CalculateTraits();
            GenerateDna();
        }

        private void CreateRandomStats()
        {
            Stats = new Stats(); 
        }

        private void CreateSpecificStats(double weight, double height, double baseHealth, double baseAggression, double baseSociality, double baseReproductivity, double defense, double attack, double mobility)
        {
            Stats = new Stats(weight, height, baseHealth, baseAggression, baseSociality, baseReproductivity, defense, attack, mobility); 
        }

        private void GenerateDna()
        {
            DnaImmitator = new DnaImmitator(Stats.Weight, Stats.Height, Stats.BaseHealth, Stats.BaseReproductivity, 
                Stats.BaseAggression, Stats.BaseSociality, Stats.Attack, Stats.Defense, Stats.Mobility);
        }

        private void CalculateTraits()
        {
            Gender = (GenderType) new Random().Next(0, 1);
        }

        private double CalculateSpeciesNumber()
        {
            return 0d;
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
            if (BodyFatPercent.Equals(0d))
                BodyFatPercent = Utilities.GenerateNormalDouble(Globals.MeanBodyFatPercent, Globals.DeviationBodyFatPercent);

            return Stats.Weight - (BodyFatPercent * Stats.Weight);
        }

        private double GenerateFatMass()
        {
            if (BodyFatPercent.Equals(0d))
                BodyFatPercent = Utilities.GenerateNormalDouble(Globals.MeanBodyFatPercent, Globals.DeviationBodyFatPercent);

            return BodyFatPercent * Stats.Weight;
        }
    }
}
