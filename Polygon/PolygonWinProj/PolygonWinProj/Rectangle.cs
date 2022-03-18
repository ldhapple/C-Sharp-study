using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolygonDLL;
using System.Drawing;

namespace PolygonWinProj
{
    class CRectangle : Polygon
    {
        public CRectangle(int x1, int y1, int x2, int y2, string rectanglename) : base(x1, y1, x2, y2, rectanglename)
        { }

        public override int GetArea()
        {
            int rArea = sizeWidth() * sizeHeight();
            return rArea;
        }

        public void DrawPolygon(Graphics g, int RectangleX, int RectangleY, Color color)
        {
            Brush rectBrush = new SolidBrush(color);
            g.FillRectangle(rectBrush, RectangleX, RectangleY, sizeWidth(), sizeHeight());
        }
    }
}
