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
        //Calculated by Health, Injury, Aggression, and Sociality
        private double Reproductivity { get; set; }
        //Calculated from body + fat mass
        private double EnergyExpenditure { get; set; }
        private Stats Stats { get; set; }
        private GridUnit Location { get; set; }

        public Entity()
        {
            Id = Globals.NextEntityId++;
            CreateRandomStats();
        }

        public Entity(double speciesNumber, double weight, double height, double bodyMass, double fatMass, double baseHealth, double baseAggression, double baseSociality, double baseReproductivity, double defense, double attack,
            double mobility, double bodyFatPercent)
        {
            Id = Globals.NextEntityId++;
            CreateSpecificStats(weight, height, bodyMass, fatMass, baseHealth, baseAggression, baseSociality, baseReproductivity, defense, attack, mobility, bodyFatPercent);
        }

        private void CreateRandomStats()
        {
            Stats = new Stats(); 
        }

        private void CreateSpecificStats(double weight, double height, double bodyMass, double fatMass, double baseHealth, double baseAggression, double baseSociality, double baseReproductivity, double defense, double attack, double mobility, double bodyFatPercent)
        {
            Stats = new Stats(weight, height, bodyMass, fatMass, baseHealth, baseAggression, baseSociality, baseReproductivity, defense, attack, mobility, bodyFatPercent); 
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
    }
}
