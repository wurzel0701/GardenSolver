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
            Node Kartoffel = new("Kartoffel");
            Node Mais = new("Mais");
            Node Papikra = new("Paprika");
            Node Tomate = new("Tomate");
            Node Zucchini = new("Zucchini");
            Node Süßkartoffel = new("Süßkartoffel");
            Node Aubergine = new("Aubergine");
            Node Kohl = new("Kohl");
            Node Lauch = new("Lauch");

            Edge edge1 = new(Gurke, Kartoffel, -1);
            Edge edge2 = new(Gurke, Mais, 1);
            Edge edge3 = new(Gurke, Papikra, 1);
            Edge edge4 = new(Gurke, Tomate, -1);
            Edge edge5 = new(Gurke, Zucchini, -1);
            Edge edge6 = new(Gurke, Kohl, 1);
            Edge edge7 = new(Gurke, Lauch, 1);
            Edge edge8 = new(Kartoffel, Mais, 1);
            Edge edge9 = new(Kartoffel, Papikra, -1);
            Edge edge10 = new(Kartoffel, Tomate, -1);
            Edge edge11 = new(Kartoffel, Kohl, 1);
            Edge edge12 = new(Mais, Tomate, 1);
            Edge edge13 = new(Mais, Zucchini, 1);
            Edge edge14 = new(Tomate, Kohl, 1);
            Edge edge15 = new(Tomate, Lauch, 1);
            Edge edge16 = new(Zucchini, Lauch, 1);
            Edge edge17 = new(Kohl, Lauch, 1);

            AddEdges(ref mainGraph, [edge1, edge2, edge3, edge4, edge5, edge6, edge7, edge8, edge9, edge10, edge11, edge12, edge13, edge14, edge15, edge16, edge17]);
            NormalizeSizes(10, ref mainGraph);
            InitSolve(ref mainGraph);
        }

        public void DrawNodesPaintHandler(object? sender, PaintEventArgs? e)
        {
            if (e is null)
            {
                return;
            }

            Graphics g = e.Graphics;
            float scale = 100f;

            g.DrawRectangle(new Pen(Pens.BurlyWood.Color, 5), new RectangleF(new(0, 0), Planter * scale));

            foreach (var node in mainGraph.nodes)
            {
                var p = node.Pos.mul(scale);
                var nodeScale = node.size * scale / 10;
                g.FillEllipse(Brushes.Blue, new RectangleF(p, new SizeF(nodeScale, nodeScale)));
                var t = TextRenderer.MeasureText(node.name, Font);
                TextRenderer.DrawText(g, node.name, Font, new Point((int)(p.X - (t.Width / 2) + (nodeScale / 2)), (int)(p.Y + 10)), Color.Black);
            }
        }
    }
}
