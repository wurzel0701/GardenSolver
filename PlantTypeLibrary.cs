using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenSolver
{
    internal class PlantTypeLibrary
    {
        private List<PlantType> AllPlants = new List<PlantType>();
        public PlantTypeLibrary() 
        {
            AllPlants.Add(new PlantType("Ackerbohne", PlantFamilyEnum.LEG, NutritionRequirementsEnum.LOW, new List<string>() { "Dill", "Kartoffel", "Kohl", "Radieschen", "Rettich", "Spinat" }, new List<string>() { }, new List<string>() { "Buschbohne", "Erbse" }));
            AllPlants.Add(new PlantType("Andenbeere", PlantFamilyEnum.NAC, NutritionRequirementsEnum.HIGH, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Artischocke", PlantFamilyEnum.KOR, NutritionRequirementsEnum.HIGH, new List<string>() { "Fenchel" }, new List<string>() { }, new List<string>() { "Knoblauch", "Schnittlauch", "Sellerie", "Zwiebel" }));
            AllPlants.Add(new PlantType("Aubergine", PlantFamilyEnum.NAC, NutritionRequirementsEnum.MEDIUM, new List<string>() { }, new List<string>() { }, new List<string>() { "Paprika", "Tomate" }));
            AllPlants.Add(new PlantType("Baldrian", PlantFamilyEnum.GEI, NutritionRequirementsEnum.MEDIUM, new List<string>() { }, new List<string>() { }, new List<string>() { "Feldsalat" }));
            AllPlants.Add(new PlantType("Basilikum", PlantFamilyEnum.LIP, NutritionRequirementsEnum.LOW, new List<string>() { "Fenchel", "Gurke", "Mangold", "Tomate", "Zucchini" }, new List<string>() { }, new List<string>() { "Bohnenkraut", "Melisse", "Salbei", "Thymian" }));
            AllPlants.Add(new PlantType("Buchweizen", PlantFamilyEnum.KNO, NutritionRequirementsEnum.LOW, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Buschbohne", PlantFamilyEnum.LEG, NutritionRequirementsEnum.LOW, new List<string>() { "Dill", "Rettich", "Radieschen", "Tomate", "Gurke", "Erdbeere", "Sellerie", "Spinat", "Rote Bete", "Kartoffel", "Kohlrabi", "Kohl", "Kopfsalat", "Kürbis", "Mais", "Pflücksalat", "Mangold", "Möhre", "Zucchini"}, new List<string>() { "Bohnenkraut", "Tagetes" }, new List<string>() { "Ackerbohne", "Fenchel", "Erbse", "Knoblauch", "Lauch", "Zwiebel" }));
            AllPlants.Add(new PlantType("Bohnenkraut", PlantFamilyEnum.LIP, NutritionRequirementsEnum.LOW, new List<string>() { "Ackerbohne", "Buschbohne", "Rote Bete", "Feldsalat", "Pflücksalat", "Kopfsalat", "Eisbergsalat", "Zwiebel"}, new List<string>() { }, new List<string>() { "Basilikum" }));
            AllPlants.Add(new PlantType("Borretsch", PlantFamilyEnum.RAU, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Gurke", "Kohlrabi", "Kohlkopf", "Tomate", "Zucchini"}, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Chicorée", PlantFamilyEnum.KOR, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Fenchel", "Kopfsalat", "Möhre", "Stangenbohne", "Tomate" }, new List<string>() { }, new List<string>() { "Kartoffel" }));
            AllPlants.Add(new PlantType("Chinakohl", PlantFamilyEnum.KRE, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Buschbohne", "Möhre", "Spinat", "Erbse", "Kopfsalat", "Pflücksalat", "Feldsalat", "Eisbergsalat"}, new List<string>() { }, new List<string>() { "Kartoffel", "Kohlrabi", "Kohl", "Rettich", "Lauch"}));
            AllPlants.Add(new PlantType("Dill", PlantFamilyEnum.DOL, NutritionRequirementsEnum.LOW, new List<string>() { "Erbse", "Möhre", "Ackerbohne", "Rote Bete", "Kopfsalat", "Pflücksalat", "Feldsalat", "Eisbergsalat", "Zucchini", "Zwiebel"}, new List<string>() { "Gurke", "Kohlkopf", "Blattkohl" }, new List<string>() { "Fenchel", "Petersilie", "Sellerie", "Kerbel", "Kümmel", "Kürbis"}));
            AllPlants.Add(new PlantType("Eisbergsalat", PlantFamilyEnum.KOR, NutritionRequirementsEnum.MEDIUM, new List<string>() { }, new List<string>() { }, new List<string>() { }));
        }
    }
}
