namespace GardenSolver
{
    using static Program;
    public partial class Form1 : Form
    {
        private void Button1_Click(object sender, EventArgs e)
        {
            Solve(ref mainGraph);
            Invalidate();
        }
        public Form1()
        {
            Paint += new PaintEventHandler(DrawNodesPaintHandler);
            InitializeComponent();

            Node Gurke = new("Gurke");
            Node Gurke2 = new("Gurke2");
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
                new(Gurke, Gurke2, 10),
                new(Gurke2, Lauch, 1),
                new(Gurke2, Kartoffel, -1),
                new(Gurke2, Mais, 1),
                new(Gurke2, Papikra, 1),
                new(Gurke2, Tomate, -1),
                new(Gurke2, Zucchini, -1),
                new(Gurke2, Kohl, 1),
                new(Gurke2, Lauch, 1),
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
