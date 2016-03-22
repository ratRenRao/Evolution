using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution
{
    public class DNAImmitator
    {
        public class DNA
        {
            Dictionary<string, int[]> DNASequence = new Dictionary<string, int[]>
            {
                {"weight", new[] {0, 0, 0, 0}},
                {"height", new[] {0, 0, 0, 0}},
                {"baseHealth", new[] {0, 0, 0, 0}},
                {"baseReproductivity", new[] {0, 0, 0, 0}},
                {"baseAggression", new[] {0, 0, 0, 0}},
                {"baseSociality", new[] {0, 0, 0, 0}},
                {"attack", new[] {0, 0, 0, 0}},
                {"defense", new[] {0, 0, 0, 0}},
                {"mobility", new[] {0, 0, 0, 0}}
            };
        }

        public DNA GenerateDNA(double weight, double height, double health, double reproduction, double aggression,
            double sociality, double attack, double defense, double mobility)
        {
            return new DNA();
        }
    }
}
