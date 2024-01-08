using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra
{
    public class Graph
    {
        public List<Vertex> listOfVertices;
        public List<Edge> listOfEdges;

        public Graph(List<Vertex> listOfVertices, List<Edge> listOfEdges)
        {
            this.listOfVertices = listOfVertices;
            this.listOfEdges = listOfEdges;
        }

        public void theShortestPath(Vertex v)
        {
            int[] distance = new int[listOfVertices.Count];
            int[] previous = new int[listOfVertices.Count];
            bool[] visited = new bool[listOfVertices.Count];
            for (int i = 0; i < listOfVertices.Count; i++)
            {
                distance[i] = int.MaxValue;
                previous[i] = int.MaxValue;
                visited[i] = false;
            }

            distance[v.value] = 0;
            previous[v.value] = -1;
            visited[v.value] = true;
            
            for (int i = 0; i < listOfVertices.Count; i++)
            {
                int min = int.MaxValue;
                int minVertex = v.value;

                foreach (Edge e in this.listOfEdges)
                {
                    if (e.start.value == minVertex && visited[e.end.value] == false)
                    {
                        if (distance[minVertex] + e.weight < distance[e.end.value])
                        {
                            distance[e.end.value] = distance[minVertex] + e.weight;
                            previous[e.end.value] = minVertex;
                        }
                        if (distance[e.end.value] < min)
                        {
                            min = distance[e.end.value];
                            minVertex = e.end.value;
                        }
                    }
                    else if (e.end.value == minVertex && visited[e.start.value] == false)
                    {
                        if (distance[minVertex] + e.weight < distance[e.start.value])
                        {
                            distance[e.start.value] = distance[minVertex] + e.weight;
                            previous[e.start.value] = minVertex;
                        }
                        if (distance[e.start.value] < min)
                        {
                            min = distance[e.start.value];
                            minVertex = e.start.value;
                        }
                    }
                }
                visited[minVertex] = true;
            }
            int[] tab = new int[listOfVertices.Count];
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = listOfVertices[i].value;
            }
            string svertices = string.Join(" ", tab);
            string sdistance = string.Join(" ", distance);
            string sprevious = string.Join(" ", previous);
            MessageBox.Show(svertices + "\n" + sdistance + "\n" + sprevious);
        }

        public int Find(int[] parent, int i)
        {
            if (parent[i] == -1)
            {
                return i;
            }
            return Find(parent, parent[i]);
        }

        public void Union(int[] parent, int x, int y)
        {
            int xSet = Find(parent, x);
            int ySet = Find(parent, y);
            parent[xSet] = ySet;
        }

        public void MinSpanningTree()
        {
            List<Edge> result = new List<Edge>();
            int[] parent = new int[this.listOfVertices.Count];
            for (int i = 0; i < parent.Length; i++)
            {
                parent[i] = -1;
            }
            this.listOfEdges = this.listOfEdges.OrderBy(edge => edge.weight).ToList();

            foreach (Edge e in this.listOfEdges)
            {
                int x = Find(parent, e.start.value);
                int y = Find(parent, e.end.value);

                if (x != y)
                {
                    result.Add(e);
                    Union(parent, x, y);
                }
            }

            foreach (Edge e in result)
            {
                MessageBox.Show($"{e.start.value} -- {e.end.value}   Waga: {e.weight}");
            }
        }
    }
}

    public class Edge
    {
        public int weight;
        public Vertex start;
        public Vertex end;

        public Edge(int weight, Vertex start, Vertex end)
        {
            this.weight = weight;
            this.start = start;
            this.end = end;
        }
    }

    public class Vertex
    {
        public int value;
        public Vertex(int value)
        {
            this.value = value;
        }
    }

