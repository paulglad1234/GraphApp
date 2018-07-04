using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphApp
{
    class Edge
    {
        public Node To;
        public Edge(Node To)
        {
            this.To = To;
        }
    }
}
