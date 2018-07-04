using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace GraphApp
{
    class Graph
    {
        public List<Node> Nodes = new List<Node>();
        public int R = 20;
        private int Selected = -1;
        public string IsConnected()
        // Является ли граф связным. Если из одной вершины можно попасть во все остальные, то 
        // граф имеет одну компоненту связности <=> граф связный.
        {
            if (Nodes != null && Nodes.Count != 0)
            {
                int counter = 1;
                for (int i = 1; i < Nodes.Count; i++)
                    if (Nodes[0].ConnectionExists(Nodes[i]))
                        counter++;
                if (counter == Nodes.Count)
                    return "Граф связный.";
                return "Граф не связный.";
            }
            return "Граф не существует или пуст!";
        }
        private Node FoundNode(int x, int y)
        {
            for (int i = 0; i < Nodes.Count; i++)
                if (Nodes[i].x - R < x && x < Nodes[i].x + R &&
                    Nodes[i].y - R < y && y < Nodes[i].y + R)
                    return Nodes[i];
            return null;
        }
        public void AddNode(int x, int y)
        {
            Nodes.Add(new Node(Nodes.Count, false, x, y, new List<Edge>()));
        }
        public void DeleteNode(int x, int y)
        {
            Node N = FoundNode(x, y);
            if (N == null) return;
            for (int i = 0; i < Nodes.Count; i++)
            {
                List<Edge> edges = new List<Edge>();
                if (Nodes[i].Edges != null)
                {
                    for (int j = 0; j < Nodes[i].Edges.Count; j++)
                    {
                        Edge e = Nodes[i].Edges[j];
                        if (e.To.Number != N.Number)
                        {
                            if (e.To.Number > N.Number) e.To.Number--;
                            edges.Add(e);
                        }
                    }
                    Nodes[i].Edges = edges;
                }
            }
            Nodes.RemoveAt(N.Number);
            for (int i = N.Number; i < Nodes.Count; i++)
                Nodes[i].Number--;
        }
        public void AddEdge(int x, int y)
        {
            Node N = FoundNode(x, y);
            if (N != null)
            {
                if (Selected == -1)
                {
                    Selected = N.Number;
                    Nodes[N.Number].Visited = true;
                }
                else
                {
                    if (Nodes[Selected].Edges == null)
                        Nodes[Selected].Edges = new List<Edge>();
                    bool AddEdge = true;
                    for (int i = 0; i < Nodes[Selected].Edges.Count; i++)
                        if (Nodes[Selected].Edges[i].To == N)
                        {
                            AddEdge = false;
                            break;
                        }
                    if (AddEdge)
                    {
                        Nodes[Selected].Edges.Add(new Edge(N));
                        N.Edges.Add(new Edge(Nodes[Selected]));
                    }
                    Nodes[Selected].Visited = false;
                    Selected = -1;
                }
            }
        }
        public void DeleteEdge(int x, int y)
        {
            Node N = FoundNode(x, y);
            if (N != null)
            {
                if (Selected == -1)
                {
                    if (N.Edges != null)
                    {
                        Selected = N.Number;
                        N.Visited = true;
                    }
                }
                else
                {
                    for (int i = 0; i < Nodes[Selected].Edges.Count; i++)
                        if (Nodes[Selected].Edges[i].To == N)
                        {
                            Nodes[Selected].Edges.RemoveAt(i);
                            for (int j = 0; j < N.Edges.Count; j++)
                                if (N.Edges[j].To == Nodes[Selected])
                                {
                                    N.Edges.RemoveAt(j);
                                    break;
                                }
                            break;
                        }
                    Nodes[Selected].Visited = false;
                    Selected = -1;
                }
            }
        }
        public void MoveNode(int x, int y)
        {
            if (Selected == -1)
            {
                Node N = FoundNode(x, y);
                if (N != null)
                {
                    Selected = N.Number;
                    N.Visited = true;
                }
            }
            else
            {
                Nodes[Selected].x = x;
                Nodes[Selected].y = y;
                Nodes[Selected].Visited = false;
                Selected = -1;
            }
        }
        public Bitmap Draw(int height, int width, DrawSet d)
        {
            Bitmap b = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(b))
            {
                g.Clear(Color.White);
                for (int i = 0; i < Nodes.Count; i++)
                {
                    float r = 3;
                    SolidBrush brush = new SolidBrush(Color.Black);
                    if (Nodes[i].Edges != null)
                        for (int j = 0; j < Nodes[i].Edges.Count; j++)
                        {
                            float X = Nodes[Nodes[i].Edges[j].To.Number].x,
                                  Y = Nodes[Nodes[i].Edges[j].To.Number].y,
                                  dl = (float)Math.Sqrt(2) / 2 * d.R,
                                  x1 = Nodes[i].x, x2 = X, y1 = Nodes[i].y, y2 = Y;
                            x1 += Nodes[i].x < X ? dl : (-1) * dl;
                            y1 += Nodes[i].y < Y ? dl : (-1) * dl;
                            x2 += Nodes[i].x > X ? dl : (-1) * dl;
                            y2 += Nodes[i].y > Y ? dl : (-1) * dl;
                            g.DrawLine(d.pen, x1, y1, x2, y2);
                            
                        }
                }
                for (int i = 0; i < Nodes.Count; i++)
                    Nodes[i].DrawNode(g, d);
            }
            return b;
        }
        public void SaveGraph(string FileName)
        {
            using (StreamWriter sw = new StreamWriter(FileName))
            {
                string str = "";
                for (int i = 0; i < Nodes.Count; i++)
                    str += Nodes[i].ToStr();
                sw.Write(str);
            }
        }
        public void LoadGraph(string FileName)
        {
            Nodes.Clear();
            using (StreamReader sr = new StreamReader(FileName))
            {
                string str = sr.ReadLine();
                List<string[]> arrEdges = new List<string[]>();
                while (str != null)
                {
                    string[] arrNode = str.Trim().Split();
                    arrEdges.Add(sr.ReadLine().Trim().Split());
                    bool visited = arrNode[2] == "True" ? true : false;
                    Node node = new Node(int.Parse(arrNode[0]),
                         visited, int.Parse(arrNode[3]), int.Parse(arrNode[4]), null);
                    Nodes.Add(node);
                    str = sr.ReadLine();
                }
                for (int i = 0; i < Nodes.Count; i++)
                {
                    List<NumEdge> NumEdges = new List<NumEdge>();
                    if (arrEdges[i][0] != "")
                        for (int j = 0; j < arrEdges[i].Length; j++)
                            NumEdges.Add(new NumEdge(int.Parse(arrEdges[i][j])));
                }
            }
        }
    }
}
