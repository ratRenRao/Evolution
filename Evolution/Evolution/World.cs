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
        private static int WorldSize { get; set; }
        private static int FoodCount { get; set; }
        private static int WaterCount { get; set; }
        private static int AvgFoodPerGridUnit { get; set; }
        private static int AvgWaterPerGridUnit { get; set; }
        private static int GridUnitCount { get; set; }
        private static int GridUnitSize { get; set; }
        public static Grid Grid { get; set; } 
        
        public static void Initialize()
        {
            SetWorldProperties();
            GenerateWorld();
        }

        public static void Run()
        {

        }

        private static void SetWorldProperties(int worldSize = 100, int foodCount = 500, int waterCount = 500)
        {
            WorldSize = worldSize; 
            FoodCount = foodCount;
            WaterCount = waterCount;
            AvgFoodPerGridUnit = FoodCount/WorldSize;
            AvgWaterPerGridUnit = WaterCount/WorldSize;
            GridUnitCount = (int) Math.Pow(WorldSize, .5);
            GridUnitSize = WorldSize/GridUnitCount; 
            var unitsPerDimension = (int) Math.Pow(GridUnitCount, .5);
            Grid = new Grid(GridUnitCount);
        }

        private static void GenerateWorld()
        {
            
        }

        private static void GenerateFood()
        {
            var remainingFood = FoodCount;

            for (var y = 0; y < GridUnitSize; y++)
                for (var x = 0; x < GridUnitSize; x++)
                {
                    var maxFood = remainingFood/4;
                    var medianFood = remainingFood/(GridUnitCount - x - 1);
                    Grid.GetUnitAt(x, y).Food = GetWeightedRandomNum(medianFood);
                }
        }

        private static void GenerateWater()
        {
            var remainingWater = WaterCount;

            for (var y = 0; y < GridUnitSize; y++)
                for (var x = 0; x < GridUnitSize; x++)
                {
                    var maxWater = remainingWater / 4;
                    var medianWater = remainingWater / (GridUnitCount - x - 1);
                    Grid.GetUnitAt(x, y).Water = GetWeightedRandomNum(medianWater);
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

        private static int GetWeightCount(int median, int i)
        {
            return (median - i);
        }
    }
}