using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Evolution
{
    public class DnaImmitator
    {
        public Dictionary<string, int> DNA = new Dictionary<string, int>
            {
                {"weight", 0},
                {"height", 0},
                {"baseHealth", 0},
                {"baseReproductivity", 0},
                {"baseAggression", 0},
                {"baseSociality", 0},
                {"attack", 0},
                {"defense", 0},
                {"mobility", 0}
            };

        public DnaImmitator(double weight, double height, double health, double reproductivity, double aggression,
            double sociality, double attack, double defense, double mobility)
        {
            DNA["weight"] = GenerateDNASnippet(weight);
            DNA["height"] = GenerateDNASnippet(height);
            DNA["baseHealth"] = GenerateDNASnippet(health);
            DNA["baseReproductivity"] = GenerateDNASnippet(reproductivity);
            DNA["baseAggression"] = GenerateDNASnippet(aggression);
            DNA["baseSociality"] = GenerateDNASnippet(sociality);
            DNA["attack"] = GenerateDNASnippet(attack);
            DNA["defense"] = GenerateDNASnippet(defense);
            DNA["mobility"] = GenerateDNASnippet(mobility);
        }

        private int GenerateDNASnippet(double value)
        {
            var bits = BitConverter.DoubleToInt64Bits(value).ToString();
            while (bits.Length < 8)
            {
                bits = "0" + bits;
            }

            return int.Parse(bits);
        }
    }
}
