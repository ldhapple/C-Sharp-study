using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PolygonDLL
{
    public interface ISize
    {
        int sizeWidth();
        int sizeHeight();
    }

    abstract public class Polygon : ISize
    {
        private string PolygonName;
        protected double PI = 3.141592;
        protected int x1, y1, x2, y2;
        public int width, height;
        public Color color;

        public Polygon(int x1, int y1, int x2, int y2, string polygonname)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.PolygonName = polygonname;
        }

        public int X
        {
            set { x1 = value; }
            get { return x1; }
        }

        public int Y
        {
            set { y1 = value; }
            get { return y1; }
        }

        public int sizeWidth()
        {
            width = x2 - x1;
            return width;
        }

        public int sizeHeight()
        {
            height = y2 - y1;
            return height;
        }

        public abstract int GetArea();
    }

}
