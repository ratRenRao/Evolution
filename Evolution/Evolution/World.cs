using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;

namespace Evolution
{
    public static class World
    {
        // World is a square, so all lengths are for both X and Y
        private static int worldSize { get; set; }
        private static int foodCount { get; set; }
        private static int avgFoodPerGridUnit { get; set; }
        private static int gridUnitCount { get; set; }
        private static int gridUnitSize { get; set; }
        public static Grid grid { get; set; } 
        
        static World()
        {
            SetWorldProperties();
            GenerateWorld();
        }

        private static void SetWorldProperties()
        {
            worldSize = 100;
            foodCount = 500;
            avgFoodPerGridUnit = foodCount / worldSize;
            gridUnitCount = (int) Math.Pow(worldSize, .5);
            gridUnitSize = worldSize/gridUnitCount; 
            var unitsPerDimension = (int) Math.Pow(gridUnitCount, .5);
            grid = new Grid(gridUnitCount);
        }

        private static void GenerateWorld()
        {
            
        }

        private static void GenerateFood()
        {
            var remainingFood = foodCount;

            for (var y = 0; y < gridUnitSize; y++)
                for (var x = 0; x < gridUnitSize; x++)
                {
                    var maxFood = remainingFood/4;
                    var medianFood = remainingFood/(gridUnitCount - x - 1);
                    grid.GetUnitAt(x, y).food = GetWeightedRandomNum(medianFood);
                }
        }

        private static int GetWeightedRandomNum(int median)
        {
            var numList = new List<int>();

            for (; median > 0; median--)
            {
                for (var i = 0; i < median; i++)
                {
                    numList.Add(median + i);
                    numList.Add(median - i);
                }
            }

            return numList.ElementAt(new Random().Next(0, numList.Count - 1));
        }

        private static int GetWeightCount(int medianFood, int i)
        {
            return (medianFood - i);
        }

        public static void Run()
        {
        }
    }
}