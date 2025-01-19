namespace GardenSolver
{
    internal class PlantTypeLibrary
    {
        private static PlantTypeLibrary Instance;

        public static List<string> AllPlantTypeNames = new List<string>();

        private List<PlantType> AllPlants = new List<PlantType>();

        private Dictionary<string, PlantType> PlantLookup = new Dictionary<string, PlantType>();
        public PlantTypeLibrary() 
        {
            Instance = this;

            AllPlants.Add(new PlantType("Ackerbohne", PlantFamilyEnum.LEG, NutritionRequirementsEnum.LOW, new List<string>() { "Dill", "Kartoffel", "Kohl", "Radieschen", "Rettich", "Spinat" }, new List<string>() { }, new List<string>() { "Buschbohne", "Erbse" }));
            AllPlants.Add(new PlantType("Andenbeere", PlantFamilyEnum.NAC, NutritionRequirementsEnum.HIGH, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Artischocke", PlantFamilyEnum.KOR, NutritionRequirementsEnum.HIGH, new List<string>() { "Fenchel" }, new List<string>() { }, new List<string>() { "Knoblauch", "Schnittlauch", "Sellerie", "Zwiebel" }));
            AllPlants.Add(new PlantType("Aubergine", PlantFamilyEnum.NAC, NutritionRequirementsEnum.MEDIUM, new List<string>() { }, new List<string>() { }, new List<string>() { "Paprika", "Tomate" }));
            AllPlants.Add(new PlantType("Baldrian", PlantFamilyEnum.GEI, NutritionRequirementsEnum.MEDIUM, new List<string>() { }, new List<string>() { }, new List<string>() { "Feldsalat" }));
            AllPlants.Add(new PlantType("Basilikum", PlantFamilyEnum.LIP, NutritionRequirementsEnum.LOW, new List<string>() { "Fenchel", "Gurke", "Mangold", "Tomate", "Zucchini" }, new List<string>() { }, new List<string>() { "Bohnenkraut", "Melisse", "Salbei", "Thymian" }));
            AllPlants.Add(new PlantType("Buchweizen", PlantFamilyEnum.KNO, NutritionRequirementsEnum.LOW, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Buschbohne", PlantFamilyEnum.LEG, NutritionRequirementsEnum.LOW, new List<string>() { "Dill", "Rettich", "Radieschen", "Tomate", "Gurke", "Erdbeere", "Sellerie", "Spinat", "Rote Bete", "Kartoffel", "Kohlrabi", "Kohl", "Kopfsalat", "Kürbis", "Mais", "Pflücksalat", "Mangold", "Möhre", "Zucchini"}, new List<string>() { "Bohnenkraut", "Tagetes" }, new List<string>() { "Ackerbohne", "Fenchel", "Erbse", "Knoblauch", "Lauch", "Zwiebel" }));
            AllPlants.Add(new PlantType("Bohnenkraut", PlantFamilyEnum.LIP, NutritionRequirementsEnum.LOW, new List<string>() { "Ackerbohne", "Buschbohne", "Rote Bete", "Feldsalat", "Pflücksalat", "Kopfsalat", "Eisbergsalat", "Zwiebel"}, new List<string>() { }, new List<string>() { "Basilikum" }));
            AllPlants.Add(new PlantType("Borretsch", PlantFamilyEnum.RAU, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Gurke", "Kohlrabi", "Kohl", "Tomate", "Zucchini"}, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Chicorée", PlantFamilyEnum.KOR, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Fenchel", "Kopfsalat", "Möhre", "Stangenbohne", "Tomate" }, new List<string>() { }, new List<string>() { "Kartoffel" }));
            AllPlants.Add(new PlantType("Chinakohl", PlantFamilyEnum.KRE, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Buschbohne", "Möhre", "Spinat", "Erbse", "Kopfsalat", "Pflücksalat", "Feldsalat", "Eisbergsalat"}, new List<string>() { }, new List<string>() { "Kartoffel", "Kohlrabi", "Kohl", "Rettich", "Lauch"}));
            AllPlants.Add(new PlantType("Dill", PlantFamilyEnum.DOL, NutritionRequirementsEnum.LOW, new List<string>() { "Erbse", "Möhre", "Ackerbohne", "Rote Bete", "Kopfsalat", "Pflücksalat", "Feldsalat", "Eisbergsalat", "Zucchini", "Zwiebel"}, new List<string>() { "Gurke", "Kohl" }, new List<string>() { "Fenchel", "Petersilie", "Sellerie", "Kerbel", "Kümmel", "Kürbis"}));
            AllPlants.Add(new PlantType("Eisbergsalat", PlantFamilyEnum.KOR, NutritionRequirementsEnum.MEDIUM, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Endivie", PlantFamilyEnum.KOR, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Fenchel", "Kohl", "Lauch", "Stangenbohne"}, new List<string>() { }, new List<string>() { "Sellerie" }));
            AllPlants.Add(new PlantType("Erbse", PlantFamilyEnum.LEG, NutritionRequirementsEnum.LOW, new List<string>() { "Dill", "Fenchel", "Gurke", "Kohl", "Kohlrabi", "Kopfsalat", "Mais", "Paprika", "Radieschen", "Rettich", "Ringelblume", "Rote Bete", "Zucchini"}, new List<string>() { "Möhre" }, new List<string>() { "Ackerbohne", "Buschbohne", "Kartoffel", "Knoblauch", "Lauch", "Mangold", "Stangenbohne", "Tomate", "Zwiebel" }));
            AllPlants.Add(new PlantType("Erdbeere", PlantFamilyEnum.ROS, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Borretsch", "Buschbohne", "Kopfsalat", "Petersilie", "Radieschen", "Rettich", "Rote Bete", "Spinat" }, new List<string>() { "Zwiebel", "Knoblauch", "Tagetes", "Schnittlauch", "Lauch", "Feldsalat" }, new List<string>() { "Kohl" }));
            AllPlants.Add(new PlantType("Feldsalat", PlantFamilyEnum.GEI, NutritionRequirementsEnum.LOW, new List<string>() { "Endivie", "Erdbeere", "Fenchel", "Kohl", "Kohlrabi", "Radieschen", "Ringelblume", "Lauch", "Stangenbohne", "Zwiebel" }, new List<string>() {  }, new List<string>() { "Baldrian" }));
            AllPlants.Add(new PlantType("Fenchel", PlantFamilyEnum.DOL, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Chicorée", "Endivie", "Erbse", "Gurke", "Kopfsalat", "Pflücksalat", "Radicchio", "Salbei" }, new List<string>() { "Feldsalat" }, new List<string>() { "Dill", "Buschbohne", "Kümmel", "Stangenbohne", "Tomate" }));
            AllPlants.Add(new PlantType("Futterrübe", PlantFamilyEnum.GAE, NutritionRequirementsEnum.HIGH, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Getreide", PlantFamilyEnum.GRA, NutritionRequirementsEnum.MEDIUM, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Gurke", PlantFamilyEnum.KÜR, NutritionRequirementsEnum.HIGH, new List<string>() { "Buschbohne", "Dill", "Erbse", "Fenchel", "Knoblauch", "Kohl", "Kopfsalat", "Koriander", "Kümmel", "Lauch", "Mais", "Paprika", "Ringelblume", "Rote Bete", "Sellerie", "Stangenbohne", "Zwiebel" }, new List<string>() { "Basilikum", "Borretsch" }, new List<string>() { "Kartoffel", "Kürbis", "Radieschen", "Rettich", "Tomate", "Zucchini"}));
            AllPlants.Add(new PlantType("Haferwurz", PlantFamilyEnum.KOR, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Ackerbohne", "Buschbohne", "Stangenbohne", "Pfefferminze", "Radieschen", "Ringelblume", "Feldsalat", "Pflücksalat", "Kopfsalat", "Eisbergsalat", "Sellerie", "Spinat", "Tomate" }, new List<string>() { }, new List<string>() { "Möhre", "Petersilie", "Schwarzwurzel"}));
            AllPlants.Add(new PlantType("Hirse", PlantFamilyEnum.GRA, NutritionRequirementsEnum.MEDIUM, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Kamille", PlantFamilyEnum.KOR, NutritionRequirementsEnum.LOW, new List<string>() { "Kohlrabi", "Kohl", "Lauch", "Sellerie" }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Kapuzinerkresse", PlantFamilyEnum.TRO, NutritionRequirementsEnum.LOW, new List<string>() { "Tomate", "Gurke", "Radieschen", "Kohl", "Kartoffel", "Erdbeere"}, new List<string>() { }, new List<string>() { "Salat", "Zwiebel", "Ackerbohne", "Buschbohne", "Stangenbohne", "Minze"}));
            AllPlants.Add(new PlantType("Kartoffel", PlantFamilyEnum.NAC, NutritionRequirementsEnum.HIGH, new List<string>() { "Ackerbohne", "Buschbohne", "Dill", "Kamille", "Kapuzinerkresse", "Kohl", "Kohlrabi", "Knoblauch", "Mais", "Minze", "Spinat" }, new List<string>() { "Ringelblume", "Tagetes", "Kümmel", "Meerrettich"}, new List<string>() { "Erbse", "Gurke", "Kürbis", "Paprika", "Rote Bete", "Sellerie", "Sonnenblume", "Tomate", "Chinakohl"}));
            AllPlants.Add(new PlantType("Kerbel", PlantFamilyEnum.DOL, NutritionRequirementsEnum.MEDIUM, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Klee", PlantFamilyEnum.LEG, NutritionRequirementsEnum.LOW, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Knoblauch", PlantFamilyEnum.LIL, NutritionRequirementsEnum.LOW, new List<string>() { "Dill", "Erdbeere", "Gurke", "Himbeere", "Kartoffel", "Möhre", "Petersilie", "Rote Bete", "Feldsalat", "Pflücksalat", "Kopfsalat", "Eisbergsalat", "Tomate" }, new List<string>() { }, new List<string>() { "Buschbohne", "Erbse", "Kohl", "Lauch", "Stangenbohne", "Zwiebel"}));
            AllPlants.Add(new PlantType("Kohl", PlantFamilyEnum.KRE, NutritionRequirementsEnum.HIGH, new List<string>() { "Ackerbohne", "Beifuß", "Endivie", "Erbse", "Gurke", "Kamille", "Koriander", "Kümmel", "Mangold", "Pastinake", "Radicchio", "Radieschen", "Rettich", "Rhabarber", "Rote Bete", "Spinat", "Stangenbohne"}, new List<string>() { "Eberraute", "Rosmarin", "Salbei", "Sellerie", "Tomate", "Basilikum", "Dill", "Ringelblume", "Tagetes", "Tomate", "Feldsalat", "Pflücksalat", "Kopfsalat", "Eisbergsalat", "Kartoffel", "Buschbohne", "Lauch", "Thymian", "Ysop", "Minze" }, new List<string>() { "Erdbeere", "Knoblauch", "Zwiebel", "Senf", "Chinakohl" }));
            AllPlants.Add(new PlantType("Kohlrabi", PlantFamilyEnum.KRE, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Buschbohne", "Erbse", "Kartoffel", "Lauch", "Radieschen", "Rettich", "Rote Bete", "Schwarzwurzel", "Sellerie", "Spargel", "Stangenbohne", "Tomate"}, new List<string>() { "Feldsalat", "Kopfsalat", "Spinat" }, new List<string>() { "Chinakohl"}));
            AllPlants.Add(new PlantType("Kopfsalat", PlantFamilyEnum.KOR, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Buschbohne", "Chicorée", "Dill", "Erbse", "Erdbeere", "Fenchel", "Gurke", "Kerbel", "Kohl", "Kohlrabi", "Kresse", "Lauch", "Mais", "Mangold", "Minze", "Möhre", "Pastinake", "Radieschen", "Rettich", "Rote Bete", "Schwarzwurzel", "Spargel", "Spinat", "Stangenbohne", "Tomate", "Zichorie", "Zwiebel"}, new List<string>() { }, new List<string>() { "Petersilie", "Sellerie" }));
            AllPlants.Add(new PlantType("Koriander", PlantFamilyEnum.DOL, NutritionRequirementsEnum.LOW, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Kresse", PlantFamilyEnum.KRE, NutritionRequirementsEnum.LOW, new List<string>() { "Radieschen" }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Kümmel", PlantFamilyEnum.DOL, NutritionRequirementsEnum.LOW, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Kürbis", PlantFamilyEnum.KÜR, NutritionRequirementsEnum.HIGH, new List<string>() { "Ackerbohne", "Buschbohne", "Stangenbohne", "Mais" }, new List<string>() { }, new List<string>() { "Gurke", "Kartoffel", "Zucchini"}));
            AllPlants.Add(new PlantType("Lauch", PlantFamilyEnum.LIL, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Endivie", "Erdbeere", "Gurke", "Kamille", "Kohl", "Kohlrabi", "Kopfsalat", "Möhre", "Pastinake", "Petersilie", "Radicchio", "Schwarzwurzel", "Tomate", "Zwiebel", "Zucchini"}, new List<string>() { "Rettich", "Sellerie", "Wermut" }, new List<string>() {"Buschbohne", "Erbse", "Rote Bete", "Stangenbohne", "Chinakohl"}));
            AllPlants.Add(new PlantType("Lavendel", PlantFamilyEnum.LIP, NutritionRequirementsEnum.LOW, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Liebstöckel", PlantFamilyEnum.DOL, NutritionRequirementsEnum.MEDIUM, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Linsen", PlantFamilyEnum.LEG, NutritionRequirementsEnum.LOW, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Lupinen", PlantFamilyEnum.LEG, NutritionRequirementsEnum.MEDIUM, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Mais", PlantFamilyEnum.GRA, NutritionRequirementsEnum.HIGH, new List<string>() { "Ackerbohne", "Buschbohne", "Stangenbohne", "Erbse", "Gurke", "Kartoffel", "Kürbis", "Melone", "Kopfsalat", "Pflücksalat", "Feldsalat", "Eisbergsalat", "Tomate", "Zucchini"}, new List<string>() { }, new List<string>() { "Sellerie", "Rote Bete" }));
            AllPlants.Add(new PlantType("Mangold", PlantFamilyEnum.GAE, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Buschbohne", "Kohl", "Möhre", "Radieschen", "Rettich", "Kopfsalat", "Pflücksalat", "Feldsalat", "Eisbergsalat" }, new List<string>() { }, new List<string>() { "Rote Bete", "Spinat"}));
            AllPlants.Add(new PlantType("Mayoran", PlantFamilyEnum.LIP, NutritionRequirementsEnum.LOW, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Melisse", PlantFamilyEnum.LIP, NutritionRequirementsEnum.LOW, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Melone", PlantFamilyEnum.KÜR, NutritionRequirementsEnum.HIGH, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Minze", PlantFamilyEnum.LIP, NutritionRequirementsEnum.HIGH, new List<string>() { "Kartoffel", "Kohl", "Kopfsalat", "Pflücksalat", "Feldsalat", "Eisbergsalat", "Möhre", "Tomate" }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Möhre", PlantFamilyEnum.DOL, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Buschbohne", "Chicorée", "Chinakohl", "Endivie", "Erbse", "Knoblauch", "Kopfsalat", "Lauch", "Mangold", "Minze", "Radieschen", "Rettich", "Salat", "Schwarzwurzel", "Tomate", "Zichorie", "Zucchini" }, new List<string>() { "Rosmarin", "Salbei", "Zwiebel", "Dill", "Schnittlauch" }, new List<string>() { "Pastinake", "Rote Bete", "Petersilie", "Sellerie" }));
            AllPlants.Add(new PlantType("Pastinake", PlantFamilyEnum.DOL, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Kohl", "Lauch", "Rote Bete", "Salat", "Spinat" }, new List<string>() { }, new List<string>() { "Fenchel", "Möhre", "Petersilie", "Sellerie" }));
            AllPlants.Add(new PlantType("Paprika", PlantFamilyEnum.NAC, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Kapuzinerkresse", "Ringelblume" }, new List<string>() { }, new List<string>() { "Kartoffel" }));
            AllPlants.Add(new PlantType("Peperoni", PlantFamilyEnum.NAC, NutritionRequirementsEnum.HIGH, new List<string>() { "Basilikum" }, new List<string>() { }, new List<string>() { "Aubergine", "Tomate", "Kartoffel" }));
            AllPlants.Add(new PlantType("Petersilie", PlantFamilyEnum.DOL, NutritionRequirementsEnum.LOW, new List<string>() { "Erdbeere", "Knoblauch", "Lauch", "Radieschen", "Rettich", "Tomate", "Zwiebel"}, new List<string>() { }, new List<string>() { "Dill", "Fenchel", "Kopfsalat", "Möhre", "Pastinake", "Salat", "Sellerie"}));
            AllPlants.Add(new PlantType("Pfefferminze", PlantFamilyEnum.LIP, NutritionRequirementsEnum.HIGH, new List<string>() { "Kartoffel", "Kohl", "Kopfsalat", "Pflücksalat", "Feldsalat", "Eisbergsalat", "Möhre", "Tomate" }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Pflücksalat", PlantFamilyEnum.KOR, NutritionRequirementsEnum.MEDIUM, new List<string>() { }, new List<string>() { "Buschbohne", "Dill", "Erbse", "Fenchel", "Gurke", "Kohl", "Mangold", "Möhre", "Pastinake", "Radieschen", "Rettich", "Rote Bete", "Schwarzwurzel", "Spargel", "Tomate", "Zichorie"}, new List<string>() { "Petersilie" }));
            AllPlants.Add(new PlantType("Phacelia", PlantFamilyEnum.RAU, NutritionRequirementsEnum.LOW, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Radicchio", PlantFamilyEnum.KOR, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Fenchel", "Kohl", "Lauch", "Stangenbohne"}, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Radieschen", PlantFamilyEnum.KRE, NutritionRequirementsEnum.LOW, new List<string>() { "Ackerbohne", "Buschbohne", "Erbse", "Erdbeere", "Kapuzinerkresse", "Kohl", "Kohlrabi", "Kresse", "Mangold", "Möhre", "Petersilie", "Pflücksalat", "Spinat", "Stangenbohne", "Tomate", "Zucchini"}, new List<string>() { "Kopfsalat" }, new List<string>() { "Gurke", "Zwiebel"}));
            AllPlants.Add(new PlantType("Raps", PlantFamilyEnum.KRE, NutritionRequirementsEnum.MEDIUM, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Rauke", PlantFamilyEnum.KRE, NutritionRequirementsEnum.LOW, new List<string>() { "Ringelblume", "Salat", "Sellerie", "Zwiebel"}, new List<string>() { }, new List<string>() { "Borretsch", "Erbse", "Gartenkresse", "Kapuzinerkresse", "Kerbel", "Koriander", "Mangold", "Spinat" }));
            AllPlants.Add(new PlantType("Rettich", PlantFamilyEnum.KRE, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Buschbohne", "Erbse", "Erdbeere", "Kapuzinerkresse", "Kohl", "Kohlrabi", "Kopfsalat", "Kresse", "Mangold", "Möhre", "Petersilie", "Pflücksalat", "Spinat", "Stangenbohne", "Tomate", "Zucchini" }, new List<string>() { }, new List<string>() { "Gurke", "Zwiebel" }));
            AllPlants.Add(new PlantType("Ringelblume", PlantFamilyEnum.KOR, NutritionRequirementsEnum.MEDIUM, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Rhabarber", PlantFamilyEnum.KNO, NutritionRequirementsEnum.HIGH, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Rosmarin", PlantFamilyEnum.LIP, NutritionRequirementsEnum.LOW, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Rote Bete", PlantFamilyEnum.FUC, NutritionRequirementsEnum.HIGH, new List<string>() { "Bohnenkraut", "Buschbohne", "Fenchel", "Gurke", "Knoblauch", "Kohl", "Kohlrabi", "Koriander", "Pastinake", "Pflücksalat", "Tomate", "Zucchini", "Zwiebel" }, new List<string>() { "Dill" }, new List<string>() { "Kartoffel", "Lauch", "Mais", "Mangold", "Möhre", "Spinat" }));
            AllPlants.Add(new PlantType("Salat", PlantFamilyEnum.KOR, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Chinakohl", "Erbse", "Erdbeere", "Dill", "Fenchel", "Gurke", "Minze", "Möhre", "Knoblauch", "Kohl", "Kohlrabi", "Rettich", "Rote Bete", "Tomate", "Zucchini" }, new List<string>() { "Kerbel" }, new List<string>() { "Petersilie", "Sellerie"}));
            AllPlants.Add(new PlantType("Salbei", PlantFamilyEnum.LIP, NutritionRequirementsEnum.LOW, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Schnittlauch", PlantFamilyEnum.LIL, NutritionRequirementsEnum.MEDIUM, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Schnittsalat", PlantFamilyEnum.KOR, NutritionRequirementsEnum.MEDIUM, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Schwarzwurzel", PlantFamilyEnum.KOR, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Kohlrabi", "Kopfsalat", "Lauch", "Pflücksalat" }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Sellerie", PlantFamilyEnum.DOL, NutritionRequirementsEnum.HIGH, new List<string>() { "Buschbohne", "Gurke", "Kamille", "Blumenkohl", "Kohlrabi", "Kopfsalat", "Lauch", "Rote Bete", "Spinat", "Stangenbohne", "Zucchini" }, new List<string>() { "Buchweizen", "Tomate", "Kohl" }, new List<string>() { "Kartoffel", "Mais", "Möhre", "Pastinake", "Petersilie"}));
            AllPlants.Add(new PlantType("Senf", PlantFamilyEnum.KRE, NutritionRequirementsEnum.LOW, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Sojabohne", PlantFamilyEnum.LEG, NutritionRequirementsEnum.MEDIUM, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Sonnenblume", PlantFamilyEnum.KOR, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Gurke" }, new List<string>() { }, new List<string>() { "Kartoffel" }));
            AllPlants.Add(new PlantType("Spargel", PlantFamilyEnum.SPA, NutritionRequirementsEnum.HIGH, new List<string>() { "Gurke", "Kopfsalat", "Petersilie", "Pflücksalat" }, new List<string>() { "Tomate" }, new List<string>() { "Knoblauch", "Zwiebel"}));
            AllPlants.Add(new PlantType("Spinat", PlantFamilyEnum.GAE, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Ackerbohne", "Buschbohne", "Chinakohl", "Erdbeere", "Kartoffel", "Kohl", "Kohlrabi", "Kopfsalat", "Pastinake", "Radieschen", "Rettich", "Sellerie", "Stangenbohne", "Tomate", "Zucchini" }, new List<string>() { }, new List<string>() { "Mangold", "Rote Bete"}));
            AllPlants.Add(new PlantType("Stachelgurke", PlantFamilyEnum.NAC, NutritionRequirementsEnum.HIGH, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Stangenbohne", PlantFamilyEnum.LEG, NutritionRequirementsEnum.LOW, new List<string>() { "Chicorée", "Endivie", "Gurke", "Kohl", "Kohlrabi", "Kopfsalat", "Radicchio", "Radieschen", "Rettich", "Sellerie", "Spinat", "Zucchini" }, new List<string>() { "Tagetes", "Bohnenkraut", "Feldsalat"}, new List<string>() { "Erbse", "Fenchel", "Knoblauch", "Lauch"}));
            AllPlants.Add(new PlantType("Tabak", PlantFamilyEnum.NAC, NutritionRequirementsEnum.HIGH, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Tagetes", PlantFamilyEnum.KOR, NutritionRequirementsEnum.MEDIUM, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Thymian", PlantFamilyEnum.LIP, NutritionRequirementsEnum.LOW, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Tomate", PlantFamilyEnum.NAC, NutritionRequirementsEnum.HIGH, new List<string>() { "Buschbohne", "Chicorée", "Kapuzinerkresse", "Knoblauch", "Kohl", "Kohlrabi", "Kopfsalat", "Lauch", "Mais", "Minze", "Möhre", "Petersilie", "Pflücksalat", "Radieschen", "Rettich", "Rote Bete", "Sellerie", "Spinat", "Zichorie", "Zwiebel" }, new List<string>() { "Basilikum", "Tagetes", "Spargel"}, new List<string>() { "Erbse", "Fenchel", "Gurke", "Kartoffel"}));
            AllPlants.Add(new PlantType("Tomatillo", PlantFamilyEnum.NAC, NutritionRequirementsEnum.HIGH, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Wicken", PlantFamilyEnum.LEG, NutritionRequirementsEnum.LOW, new List<string>() { }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Zichorie", PlantFamilyEnum.KOR, NutritionRequirementsEnum.MEDIUM, new List<string>() { "Fenchel", "Kopfsalat", "Möhre", "Stangenbohne", "Tomate" }, new List<string>() { }, new List<string>() { }));
            AllPlants.Add(new PlantType("Zucchini", PlantFamilyEnum.KÜR, NutritionRequirementsEnum.HIGH, new List<string>() { "Buschbohne", "Dill", "Erbse", "Kapuzinerkresse", "Lauch", "Mais", "Möhre", "Petersilie", "Radieschen", "Rettich", "Rote Bete", "Kopfsalat", "Spinat", "Sellerie", "Stangenbohne", "Zwiebel" }, new List<string>() { "Borretsch" }, new List<string>() { "Gurke", "Kürbis" }));
            AllPlants.Add(new PlantType("Zwiebel", PlantFamilyEnum.LIL, NutritionRequirementsEnum.LOW, new List<string>() { "Bohnenkraut", "Dill", "Erdbeere", "Gurke", "Kamille", "Kopfsalat", "Petersilie", "Rote Bete", "Schwarzwurzel", "Tomate", "Zichorie", "Zucchini" }, new List<string>() { "Möhre", "Feldsalat"}, new List<string>() { "Buschbohne", "Erbse", "Kohl", "Knoblauch", "Rettich", "Stangenbohne"}));

            foreach (PlantType item in AllPlants) 
            {
                if (item.ValidateInternal()) 
                {
                    PlantLookup.Add(item.PlantName, item);
                }
            }

            foreach (PlantType item in AllPlants) 
            {
                foreach (string good in item.GoodNeighbours) 
                {
                    if (!PlantLookup.ContainsKey(good)) 
                    {
                        Console.WriteLine(item.PlantName + ": " + good + " in good neighbors is not a registered plant");
                    }
                }

                foreach (string perfect in item.PerfectNeighbours)
                {
                    if (!PlantLookup.ContainsKey(perfect))
                    {
                        Console.WriteLine(item.PlantName + ": " + perfect + " in perfect neighbors is not a registered plant");
                    }
                }

                foreach (string bad in item.BadNeighbours)
                {
                    if (!PlantLookup.ContainsKey(bad))
                    {
                        Console.WriteLine(item.PlantName + ": " + bad + " in bad neighbors is not a registered plant");
                    }
                }

                AllPlantTypeNames.Add(item.PlantName);
            }
        
        }

        public static short GetPlantRelation(string from, string to) 
        {
            if (from == to) 
            {
                return 0;
            }

            if (Instance.PlantLookup.ContainsKey(from)) 
            {
                PlantType fromType = Instance.PlantLookup[from];

                if (fromType.GoodNeighbours.Contains(to)) 
                {
                    return 1;
                }

                if (fromType.PerfectNeighbours.Contains(to)) 
                {
                    return 2;
                }

                if (fromType.BadNeighbours.Contains(to)) 
                {
                    return -1;
                }

                return 0;
            }

            throw new ArgumentException("The given plant type " + from + " is not a registered plant");
        }

        public static PlantType GetPlantTypeOfName (string plantType)
        {
            return Instance.PlantLookup[plantType];
        }
    }
}
