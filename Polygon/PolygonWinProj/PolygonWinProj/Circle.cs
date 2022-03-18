using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using PolygonDLL;

namespace PolygonWinProj
{
    class CCircle : Polygon
    {
        public CCircle(int x1, int y1, int x2, int y2, string circlename) : base(x1,y1,x2,y2,circlename)
        { }

        public override int GetArea()
        {
            int cArea = sizeWidth() * sizeHeight();
            return cArea;
        }

        public void DrawPolygon(Graphics g, int CircleX, int CircleY, Color color)
        {
            Brush circleBrush = new SolidBrush(color);
            g.FillEllipse(circleBrush, CircleX, CircleY, sizeWidth(), sizeHeight());
        }
    }
}
