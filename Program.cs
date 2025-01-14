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
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static SizeF Planter = new(5, 1.2f);
        static float scale = 1;
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
                node.Pos = new PointF((float)Random.Shared.NextDouble() * (float)Planter.Width, (float)Random.Shared.NextDouble() * (float)Planter.Height);
            }
        }

        public static void Solve(ref Graph graph)
        {
            for (int i = 0; i < graph.edges.Count; i++)
            {
                Edge edge = graph.edges[i];
                edge.plant1.Pos = edge.plant1.Pos.add(edge.plant2.Pos.sub(edge.plant1.Pos).mul(edge.weight * (Planter.Width / graph.nodes.Count) * scale));
            }

            for (int i = 0; i < graph.nodes.Count; i++)
            {
                Node node = graph.nodes[i];
                for (int j = 0; i < graph.nodes.Count; i++)
                {
                    Node node2 = graph.nodes[j];
                    if (i != j)
                    {
                        node.Pos = node.Pos.add(node2.Pos.sub(node.Pos).mul(-0.03f));
                    }
                }
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

            public PointF Pos { get { return _pos; } set { _pos = new(MathF.Min(Planter.Width, value.X), MathF.Min(Planter.Height, value.Y)); } }
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