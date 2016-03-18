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
        private double RequiredFood { get; set; }
        private double FoodConsumptionRate { get; set; }
        private double RequiredWater { get; set; }
        private double WaterConsumptionRate { get; set; }
        private double Hunger { get; set; }
        private double Thirst { get; set; }
        //Calculated from body + fat mass
        private double EnergyExpenditure { get; set; }
        private Stats Stats { get; set; }
        private GridUnit Location { get; set; }
    }
}
