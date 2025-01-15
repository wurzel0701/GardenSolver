namespace GardenSolver
{
    internal enum PlantFamilyEnum { UNSET, DOL, FUC, GAE, GEI, GRA, KNO, KOR, KRE, KÜR, LEG, LIL, LIP, NAC, RAU, ROS, SPA };

    internal enum NutritionRequirementsEnum { UNSET, LOW, MEDIUM, HIGH };

    internal class PlantType
    {
        public string PlantName { get; private set; } = "";

        public PlantFamilyEnum PlantFamily { get; private set; } = PlantFamilyEnum.UNSET;

        public NutritionRequirementsEnum NutritionRequirements { get; private set; } = NutritionRequirementsEnum.UNSET;

        public List<string> GoodNeighbours { get; private set; } = new List<string>();

        public List<string> PerfectNeighbours { get; private set; } = new List<string>();

        public List<string> BadNeighbours { get; private set; } = new List<string>();

        public PlantType(string name, PlantFamilyEnum family, NutritionRequirementsEnum nutrition, List<string> good, List<string> perfect, List<string> bad) 
        {
            PlantName = name;
            PlantFamily = family;
            NutritionRequirements = nutrition;
            GoodNeighbours = good;
            PerfectNeighbours = perfect;
            BadNeighbours = bad;
        }

        public bool ValidateInternal() 
        {
            foreach (string good in GoodNeighbours) 
            {
                if (PerfectNeighbours.Contains(good)) 
                {
                    Console.WriteLine(good + " is sorted into good and perfect neighbours, can only be one");
                    return false;
                }

                if (BadNeighbours.Contains(good))
                {
                    Console.WriteLine(good + " is sorted into good and bad neighbours, can only be one");
                    return false; 
                }
            }

            foreach (string bad in BadNeighbours)
            {
                if (PerfectNeighbours.Contains(bad))
                {
                    Console.WriteLine(bad + " is sorted into perfect and bad neighbours, can only be one");
                    return false;
                }
            }

            return true;
        }
    }
}
