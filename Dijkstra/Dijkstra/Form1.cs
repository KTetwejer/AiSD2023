namespace Dijkstra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vertex v0 = new Vertex(0);
            Vertex v1 = new Vertex(1);
            Vertex v2 = new Vertex(2);
            Vertex v3 = new Vertex(3);
            Vertex v4 = new Vertex(4);
            Vertex v5 = new Vertex(5);

            Edge e01 = new Edge(3, v0, v1);
            Edge e04 = new Edge(3, v0, v4);
            Edge e05 = new Edge(6, v0, v5);
            Edge e12 = new Edge(1, v1, v2);
            Edge e13 = new Edge(4, v1, v3);
            Edge e23 = new Edge(3, v2, v3);
            Edge e25 = new Edge(1, v2, v5);
            Edge e35 = new Edge(1, v3, v5);
            Edge e45 = new Edge(2, v4, v5);

            List<Vertex> vertices = new List<Vertex>();
            vertices.Add(v0);
            vertices.Add(v1);
            vertices.Add(v2);
            vertices.Add(v3);
            vertices.Add(v4);
            vertices.Add(v5);

            List<Edge> edges = new List<Edge>();
            edges.Add(e01);
            edges.Add(e04);
            edges.Add(e05);
            edges.Add(e12);
            edges.Add(e13);
            edges.Add(e23);
            edges.Add(e25);
            edges.Add(e35);
            edges.Add(e45);

            Graph g = new Graph(vertices, edges);

            g.theShortestPath(v0);
        }
    }
}