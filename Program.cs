namespace GardenSolver
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            PlantTypeLibrary ptl = new PlantTypeLibrary();
            Planter planter1 = new Planter(NutritionRequirementsEnum.LOW);
            planter1.SetChoosenPlantTypes(new List<string>() { "Buschbohne", "Erbse", "Knoblauch", "Schnittlauch", "Petersilie", "Rosmarin", "Basilikum", "Thymian" });
            Planter planter2 = new Planter(NutritionRequirementsEnum.MEDIUM);
            planter2.SetChoosenPlantTypes(new List<string>() { "Möhre", "Salat", "Tomatillo", "Rote Bete", "Spinat", "Kohlrabi", "Zwiebel" });
            Planter planter3 = new Planter(NutritionRequirementsEnum.HIGH);
            planter3.SetChoosenPlantTypes(new List<string>() { "Gurke", "Kartoffel", "Mais", "Paprika", "Tomate", "Zucchini", "Aubergine", "Kohl", "Lauch" /*, "Süßkartoffel" */ });
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static SizeF PlanterTest = new(5, 1.2f);
        public static Graph mainGraph = new();

        public static void AddEdges(ref Graph graph, List<Edge> edges)
        {
            foreach (var edge in edges)
            {
                graph.edges.Add(edge);
                if (!graph.nodes.Contains(edge.plant1))
                {
                    graph.nodes.Add(edge.plant1);
                }
                if (!graph.nodes.Contains(edge.plant2))
                {
                    graph.nodes.Add(edge.plant2);
                }
            }
        }
        public static void AddNodes(ref Graph graph, List<Node> nodes)
        {
            foreach (var node in nodes)
            {
                if (!graph.nodes.Contains(node))
                {
                    graph.nodes.Add(node);
                }
            }
        }

        public static void NormalizeSizes(float totalSize, ref Graph graph)
        {
            float SumOfNodes = 0;
            for (int i = 0; i < graph.nodes.Count; i++)
            {
                SumOfNodes += graph.nodes[i].size;
            }

            //float SumOfEdges = 0;
            //for (int i = 0; i < graph.edges.Count; i++)
            //{
            //    SumOfEdges += graph.edges[i].weight;
            //}

            for (int i = 0; i < graph.nodes.Count; i++)
            {
                Node node = graph.nodes[i];
                node.size = node.size / SumOfNodes * totalSize;
            }
        }

        public static void InitSolve(ref Graph graph)
        {
            for (int i = 0; i < graph.nodes.Count; i++)
            {
                Node node = graph.nodes[i];
                node.Pos = new PointF((float)Random.Shared.NextDouble() * (float)PlanterTest.Width, (float)Random.Shared.NextDouble() * (float)PlanterTest.Height);
            }
        }

        public static void Solve(ref Graph graph)
        {
            PointF[] newPositions = new PointF[graph.nodes.Count];
            for (int i = 0; i < graph.nodes.Count; i++)
            {
                newPositions[i] = graph.nodes[i].Pos;
            }

            for (int i = 0; i < graph.edges.Count; i++)
            {
                Edge edge = graph.edges[i];
                var diff = edge.plant2.Pos.sub(edge.plant1.Pos);
                var node1Index = graph.nodes.IndexOf(edge.plant1);
                var node2Index = graph.nodes.IndexOf(edge.plant2);

                float spacer = 1 / MathF.Sqrt(diff.mag());
                spacer = 0.01f;
                newPositions[node1Index] = newPositions[node1Index].add(diff.mul(edge.weight * spacer));
                newPositions[node2Index] = newPositions[node2Index].add(diff.mul(edge.weight * -spacer));
            }
            for (int i = 0; i < graph.nodes.Count; i++)
            {
                Node node = graph.nodes[i];
                if (i == graph.nodes.Count - 1)
                {
                    continue;
                }
                for (int j = i + 1; j < graph.nodes.Count; j++)
                {
                    Node node2 = graph.nodes[j];

                    PointF diff1 = node2.Pos.sub(node.Pos);

                    if (diff1.mag() < 2)
                    {
                        float spacer = 1f / MathF.Pow(diff1.mag(), 2f);
                        spacer /= 110;

                        newPositions[i] = newPositions[i].add(diff1.mul(-spacer));
                        newPositions[j] = newPositions[j].add(diff1.mul(spacer));
                    }
                }
            }

            for (int i = 0; i < graph.nodes.Count; i++)
            {
                graph.nodes[i].Pos = newPositions[i];
            }
        }

        public static PointF add(this PointF a, PointF b) => new(a.X + b.X, a.Y + b.Y);
        public static PointF sub(this PointF a, PointF b) => new(a.X - b.X, a.Y - b.Y);
        public static PointF mul(this PointF a, PointF b) => new(a.X * b.X, a.Y * b.Y);
        public static PointF div(this PointF a, PointF b) => new(a.X / b.X, a.Y / b.Y);
        public static PointF mul(this PointF a, float b) => new(a.X * b, a.Y * b);
        public static PointF div(this PointF a, float b) => new(a.X / b, a.Y / b);
        public static PointF add(this PointF a, float b) => new(a.X + b, a.Y + b);
        public static PointF sub(this PointF a, float b) => new(a.X - b, a.Y - b);

        public static float mag(this PointF a) => MathF.Sqrt(a.X * a.X + a.Y * a.Y);

        public class Edge
        {
            public Node plant1;
            public Node plant2;
            public float weight; // positive: plant 1 is good for  plant 2 

            public Edge(Node plant1, Node plant2, float weight)
            {
                this.plant1 = plant1;
                this.plant2 = plant2;
                this.weight = weight;
            }
        }

        public class Node
        {
            public float size = 1;
            public string name;
            private PointF _pos = new(0, 0);

            public Node(string name)
            {
                this.name = name;
            }

            public PointF Pos { get { return _pos; } set { _pos = new(MathF.Max(0, MathF.Min(PlanterTest.Width, value.X)), MathF.Max(0, MathF.Min(PlanterTest.Height, value.Y))); } }

            public override string ToString() => name + " {" + Pos.X + ";" + Pos.Y + "}";
        }

        public class Graph
        {
            public string name = string.Empty;
            public List<Node> nodes = [];
            public List<Edge> edges = [];

            public Graph()
            {
            }
        }
    }
}