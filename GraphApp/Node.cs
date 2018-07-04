using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphApp
{
    class Node
    {
        public int Number;
        public bool Visited;
        public float x;
        public float y;
        public List<Edge> Edges;
        public Node(int Number, bool Visited, float x, float y, List<Edge> Edges)
        {
            this.Number = Number;
            this.Visited = Visited;
            this.x = x;
            this.y = y;
            this.Edges = Edges;
        }
        public bool IsEdgeTo(Node To) //Есть ли вершина между ребрами
        {
            if (Edges != null && Edges.Count != 0)
                for (int i = 0; i < Edges.Count; i++)
                    if (Edges[i].To == To)
                        return true;
            return false;
        }
        public bool ConnectionExists(Node To) //Проверка доступности одной вершины из другой
        {
            Visited = true;
            if (IsEdgeTo(To))
            {
                Visited = false;
                return true;
            }
            if (Edges != null && Edges.Count != 0)
                for (int i = 0; i < Edges.Count; i++)
                    if (!Edges[i].To.Visited)
                        if (Edges[i].To.ConnectionExists(To))
                        {
                            Visited = false;
                            return true;
                        }
            Visited = false;
            return false;
        }
        public string ToStr()
        {
            string s = Number.ToString() + " " +
                         Visited.ToString() + " " +
                         x.ToString() + " " + y.ToString() + Environment.NewLine;
            if (Edges != null)
                for (int i = 0; i < Edges.Count; i++)
                    s += Edges[i].To.Number.ToString() + " ";
            s += Environment.NewLine;
            return s;
        }
        public void DrawNode(Graphics g, DrawSet d)
        {
            SolidBrush Brush = Visited ? d.brushVisited : d.brushNotVisited;
            g.FillEllipse(Brush, x - d.R, y - d.R, 2 * d.R, 2 * d.R);
            g.DrawEllipse(d.pen, x - d.R, y - d.R, 2 * d.R, 2 * d.R);
            string s = Convert.ToString(Number);
            SizeF size = g.MeasureString(s, d.font);
            g.DrawString(s, d.font, d.brushText,
                x - size.Width / 2,
                y - size.Height / 2);
        }

    }
}
