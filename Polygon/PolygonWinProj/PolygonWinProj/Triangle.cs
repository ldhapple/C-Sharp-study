using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolygonDLL;
using System.Drawing;

namespace PolygonWinProj
{
    class Triangle : Polygon
    {
        public Triangle(int x1, int y1, int x2, int y2, string rectanglename) : base(x1, y1, x2, y2, rectanglename)
        { }

        public override int GetArea()
        {
            int rArea = sizeWidth() * sizeHeight() / 2;
            return rArea;
        }

        public void DrawPolygon(Graphics g, int X, int Y, Color color)
        {
            Point[] points = { new Point(100, 100), new Point(200, 100), new Point(150, 10) };
            Brush tBrush = new SolidBrush(color);
            g.FillPolygon(tBrush, points);
        }
    }
}
