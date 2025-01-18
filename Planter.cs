using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenSolver
{
    internal class Planter
    {
        public NutritionRequirementsEnum PlanterNutrition { get; private set; }

        public bool HasRoof { get; private set; }

        private List<PlantType> ChoosenPlantTypes;

        private List<PlantType> BestFittingPlants = new List<PlantType>(3);

        private List<PlantType> WorstFittingPlants = new List<PlantType>(3);

        private List<PlantType> SuggestedPlants = new List<PlantType>(5);

        private short[,] CompatMatrix;

        public Planter(NutritionRequirementsEnum planterNutrition) 
        {
            PlanterNutrition = planterNutrition;
        }

        public void SetChoosenPlantTypes(List<PlantType> choosen) 
        {
            ChoosenPlantTypes = choosen;
            CalculateCompatibilityMatrix();
            CalculateRatings();
            CalculateSuggestions();
        }

        private void CalculateCompatibilityMatrix() 
        {
            //This should be its own class
            CompatMatrix = new short[ChoosenPlantTypes.Count, ChoosenPlantTypes.Count];


        }

        private void CalculateRatings() 
        {

        }

        private void CalculateSuggestions()
        {
        }
    }
}
