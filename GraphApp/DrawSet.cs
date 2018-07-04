using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphApp
{
    class DrawSet
    {
        public Pen pen;
        public SolidBrush brushNotVisited;
        public SolidBrush brushVisited;
        public SolidBrush brushText;
        public Font font;
        public int R;
        public DrawSet(Color penColor, Color brushNV, Color brushV, Color brushT, Font f, int r)
        {
            pen = new Pen(penColor);
            brushNotVisited = new SolidBrush(brushNV);
            brushVisited = new SolidBrush(brushV);
            brushText = new SolidBrush(brushT);
            font = f;
            R = r;
        }
    }
}
