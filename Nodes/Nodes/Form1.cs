using Microsoft.VisualBasic;
using System.ComponentModel.Design;

namespace Nodes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void A(Node w)
        {
            MessageBox.Show(w.value.ToString());
            foreach (var kid in w.kids)
            {
                A(kid);
            }
        }

        void bfs(List<Node> visited)
        {
            for (int i = 0; i < visited.Count; i++)
            {
                var w = visited[i];
                MessageBox.Show(w.value.ToString());
                foreach(var kid in w.kids)
                {
                    if(!visited.Contains(kid))
                    {
                        visited.Add(kid);
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var w1 = new Node(5);
            var w2 = new Node(1);
            var w3 = new Node(2);
            w1.kids.Add(w2);
            w1.kids.Add(w3);
            var w4 = new Node(3);
            var w5 = new Node(8);
            w2.kids.Add(w4);
            w2.kids.Add(w5);
            var w6 = new Node(4);
            w3.kids.Add(w6);

            //A(w1);
            var visited = new List<Node>();
            bfs(visited);
        }



    }
}