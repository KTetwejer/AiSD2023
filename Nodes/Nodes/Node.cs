using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodes
{
    internal class Node
    {
        public int value;
        public List<Node> kids = new();

        public Node(int a)
        {
            this.value = a;
        }
    }
}
