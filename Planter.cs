﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenSolver
{
    internal class Planter(NutritionRequirementsEnum planterNutrition, string name, bool isOutside, float width, float length)
    {
        public string Name { get; set; } = name;

        public NutritionRequirementsEnum PlanterNutrition { get; set; } = planterNutrition;

        public bool IsOutside { get; set; } = isOutside;

        public int PlantAmount => ChoosenPlantTypes.Count;

        public List<string> ChoosenPlantTypes = new List<string>();

        private Dictionary<string, short> PlantTypeRating = new Dictionary<string, short>();

        private List<string> SuggestedPlants = new List<string>(5);

        private Dictionary<string, short> SuggestionRating = new Dictionary<string, short>();

        private short[,] CompatMatrix = new short[0, 0];

        private short PlanterRating = 0;

        public float m_width = width;

        public float m_length = length;

        public short CheckCompatibilityOf(string plantType) 
        {
            //Planter not set yet, cannot compare
            if (ChoosenPlantTypes == null || ChoosenPlantTypes.Count == 0) 
            {
                return short.MinValue;
            }

            //Plant already in planter
            if (PlantTypeRating.ContainsKey(plantType)) 
            {
                return short.MinValue; 
            }

            //Plant unfit for planter
            if (PlanterNutrition < PlantTypeLibrary.GetPlantTypeOfName(plantType).NutritionRequirements) 
            {
                return short.MinValue;
            }

            short rating = 0;

            foreach (string plant in ChoosenPlantTypes) 
            {
                rating += PlantTypeLibrary.GetPlantRelation(plantType, plant);
                rating += PlantTypeLibrary.GetPlantRelation(plant, plantType);
            }

            return rating;
        }

        public void SetChoosenPlantTypes(List<string> choosen) 
        {
            ChoosenPlantTypes.Clear();
            ChoosenPlantTypes.AddRange(choosen);
            CalculateCompatibilityMatrix();
            //CalculateSuggestions();
        }

        private void CalculateCompatibilityMatrix() 
        {
            CompatMatrix = new short[ChoosenPlantTypes.Count, ChoosenPlantTypes.Count];

            for (int i = 0; i < ChoosenPlantTypes.Count; i++) 
            {
                short plantRating = 0;
                for (int j = 0; j < ChoosenPlantTypes.Count; j++) 
                {
                    CompatMatrix[i, j] = PlantTypeLibrary.GetPlantRelation(ChoosenPlantTypes[i], ChoosenPlantTypes[j]);
                    plantRating += CompatMatrix[i, j];
                }

                PlantTypeRating.Add(ChoosenPlantTypes[i], plantRating);
            }

            ChoosenPlantTypes.Sort( (x, y) => (PlantTypeRating[y].CompareTo(PlantTypeRating[x])));

            foreach (string item in ChoosenPlantTypes) 
            {
                Console.WriteLine(item + ": " + PlantTypeRating[item]);
                PlanterRating += PlantTypeRating[item];
            }

            Console.WriteLine("Overall planter rating: " + PlanterRating);

        }

        public void CalculateSuggestions()
        {
            foreach (string name in PlantTypeLibrary.AllPlantTypeNames) 
            {
                short rating = CheckCompatibilityOf(name);

                if (rating > 0) 
                {
                    SuggestedPlants.Add(name);
                    SuggestionRating.Add(name, rating);
                }
            }

            SuggestedPlants.Sort( (x, y) => (SuggestionRating[y].CompareTo(SuggestionRating[x])));

            for (int i = 0; i < Math.Min(5, SuggestedPlants.Count); i++) 
            {
                Console.WriteLine("Suggesting " + SuggestedPlants[i] + " with rating change of " + SuggestionRating[SuggestedPlants[i]]);
            }
        }
    }
}
