namespace Dijkstra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void rozpin()
        {
            Vertex v0 = new Vertex(0);
            Vertex v1 = new Vertex(1);
            Vertex v2 = new Vertex(2);
            Vertex v3 = new Vertex(3);
            Vertex v4 = new Vertex(4);
            Vertex v5 = new Vertex(5);
            Vertex v6 = new Vertex(6);
            Vertex v7 = new Vertex(7);

            Edge e46 = new Edge(1, v4, v6);
            Edge e45 = new Edge(2, v4, v5);
            Edge e27 = new Edge(3, v2, v7);
            Edge e06 = new Edge(3, v0, v6);
            Edge e24 = new Edge(4, v2, v4);
            Edge e01 = new Edge(5, v0, v1);
            Edge e26 = new Edge(5, v2, v6);
            Edge e15 = new Edge(6, v1, v5);
            Edge e56 = new Edge(6, v5, v6);
            Edge e17 = new Edge(7, v1, v7);
            Edge e14 = new Edge(8, v1, v4);
            Edge e36 = new Edge(8, v3, v6);
            Edge e03 = new Edge(9, v0, v3);
            Edge e12 = new Edge(9, v1, v2);
            Edge e23 = new Edge(9, v2, v3);
            Edge e67 = new Edge(9, v6, v7);

            List<Vertex> vertices = new List<Vertex>();
            vertices.Add(v0);
            vertices.Add(v1);
            vertices.Add(v2);
            vertices.Add(v3);
            vertices.Add(v4);
            vertices.Add(v5);
            vertices.Add(v6);
            vertices.Add(v7);

            List<Edge> edges = new List<Edge>();
            edges.Add(e46);
            edges.Add(e45);
            edges.Add(e27);
            edges.Add(e06);
            edges.Add(e24);
            edges.Add(e01);
            edges.Add(e26);
            edges.Add(e15);
            edges.Add(e56);
            edges.Add(e17);
            edges.Add(e14);
            edges.Add(e36);
            edges.Add(e03);
            edges.Add(e12);
            edges.Add(e23);
            edges.Add(e67);


            Graph g = new Graph(vertices, edges);


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
