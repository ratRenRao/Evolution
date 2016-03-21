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
        //Calculated from body + fat mass
        private double EnergyExpenditure { get; set; }
        private Stats Stats { get; set; }
        private GridUnit Location { get; set; }

        public Entity()
        {
            CreateRandomStats();
        }

        public Entity(double speciesNumber, double weight, double height, double bodyMass, double fatMass, double health,
            double injury, double aggression, double sociality, double reproductivity, double defense, double attack,
            double mobility)
        {
            CreateSpecificStats(speciesNumber, weight, height, bodyMass, fatMass, health, injury, aggression, sociality, reproductivity, defense, attack, mobility);
        }

        private void CreateRandomStats()
        {
            Stats = new Stats(); 
        }

        private void CreateSpecificStats(double speciesNumber, double weight, double height, double bodyMass, double fatMass, double health, double injury, double aggression, double sociality, double reproductivity, double defense, double attack, double mobility)
        {
            Stats = new Stats(speciesNumber, weight, height, bodyMass, fatMass, health, injury, aggression, sociality, reproductivity, defense, attack, mobility); 
        }
    }
}
