namespace GardenSolver
{
    using System.Timers;
    using static Program;
    public partial class Form1 : Form
    {
        bool isRunning = false;
        bool isFirstTime = false;
        System.Timers.Timer timer = new();

        private void Button1_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;
            button1.Text = isRunning ? "Solving" : "Solve";
            if (!isFirstTime)
            {
                isFirstTime = true;
                timer.Elapsed += new System.Timers.ElapsedEventHandler((object? s, ElapsedEventArgs e) =>
                {
                    Solve(ref mainGraph);
                    Invalidate();
                });
                timer.Interval = 50;
            }
            if (isRunning)
            {
                timer.Start();
            }
            else
            {
                timer.Stop();
            }
        }

        public Form1()
        {
            Paint += new PaintEventHandler(DrawNodesPaintHandler);
            InitializeComponent();

            Node Gurke = new("Gurke");
            Node Gurke2 = new("Gurke2");
            Node Gurke3 = new("Gurke3");
            Node Gurke4 = new("Gurke4");
            Node Gurke5 = new("Gurke5");
            Node Kartoffel = new("Kartoffel");
            Node Mais = new("Mais");
            Node Papikra = new("Paprika");
            Node Tomate = new("Tomate");
            Node Zucchini = new("Zucchini");
            Node Süßkartoffel = new("Süßkartoffel");
            Node Aubergine = new("Aubergine");
            Node Kohl = new("Kohl");
            Node Lauch = new("Lauch");

            List<Edge> edges =
            [
                new(Gurke, Kartoffel, -1),
                new(Gurke, Mais, 1),
                new(Gurke, Papikra, 1),
                new(Gurke, Tomate, -1),
                new(Gurke, Zucchini, -1),
                new(Gurke, Kohl, 1),
                new(Gurke, Lauch, 1),
                new(Gurke, Gurke2, 10),
                new(Gurke, Gurke3, 10),
                new(Gurke, Gurke4, 10),
                new(Gurke, Gurke5, 10),
                new(Gurke2, Gurke3, 10),
                new(Gurke2, Gurke4, 10),
                new(Gurke2, Gurke5, 10),
                new(Gurke3, Gurke4, 10),
                new(Gurke3, Gurke5, 10),
                new(Gurke4, Gurke5, 10),
                new(Kartoffel, Mais, 1),
                new(Kartoffel, Papikra, -1),
                new(Kartoffel, Tomate, -1),
                new(Kartoffel, Kohl, 1),
                new(Mais, Tomate, 1),
                new(Mais, Zucchini, 1),
                new(Tomate, Kohl, 1),
                new(Tomate, Lauch, 1),
                new(Zucchini, Lauch, 1),
                new(Kohl, Lauch, 1),
            ];

            AddEdges(ref mainGraph, edges);
            NormalizeSizes(10, ref mainGraph);
            InitSolve(ref mainGraph);
        }

        PointF origin = new(30, 30);

        public void DrawNodesPaintHandler(object? sender, PaintEventArgs? e)
        {
            if (e is null)
            {
                return;
            }

            Graphics g = e.Graphics;
            float scale = 100f;

            g.DrawRectangle(new Pen(Pens.BurlyWood.Color, 5), new RectangleF(origin.sub(new PointF(1, 1)), (Planter * scale) + new SizeF(15, 15)));

            foreach (var node in mainGraph.nodes)
            {
                var p = node.Pos.mul(scale);
                var nodeScale = node.size * scale / 10;
                g.FillEllipse(Brushes.Blue, new RectangleF(p.add(origin), new SizeF(nodeScale, nodeScale)));
                var t = TextRenderer.MeasureText(node.name, Font);
                TextRenderer.DrawText(g, node.name, Font, new Point((int)(p.X - (t.Width / 2) + (nodeScale / 2) + (int)origin.X), (int)(p.Y + 10) + (int)origin.Y), Color.Black);
            }
        }
    }
}
