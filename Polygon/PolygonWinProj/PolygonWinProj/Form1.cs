using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PolygonDLL;

namespace PolygonWinProj
{
    public partial class Form1 : Form
    {
        #region _전역변수_
        CRectangle r = new CRectangle(10,10,60,60,"Rectangle");
        CCircle c = new CCircle(20, 20, 70, 70, "Circle");
        Triangle t = new Triangle(20, 20, 200, 200, "Triangle");

        // 사각형과 원의 위치정보
        Point rectPos = new Point(0, 0);
        Point circlePos = new Point(0, 0);
        Point trianglePos = new Point(0, 0);

        Color colorRect = Color.Red;
        Color colorCircle = Color.Blue;
        Color colorTriangle = Color.Green;

        // 현재 사각형이 클릭 되었는지 원이 클릭되었는지
        bool exitRect = false;
        bool exitCircle = false;
        bool exitTriangle = false;

        // 현재 사각형을 이동하는지 원을 이동하는지
        bool moveRect = false;
        bool moveCircle = false;
        bool moveTriangle = false;

        // 마우스의 위치
        Point fixMouse = new Point(0, 0);

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            Rectangle.Checked = !Rectangle.Checked;
            if (Rectangle.Checked == true)
            {
                exitRect = true;
                MyPanel.Invalidate();
            }
            else
            {
                exitRect = false;
                MyPanel.Invalidate();
            }
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            Circle.Checked = !Circle.Checked;
            if (Circle.Checked == true)
            {
                exitCircle = true;
                MyPanel.Invalidate();
            }

            else
            {
                exitCircle = false;
                MyPanel.Invalidate();
            }
        }

      

        private void MyPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if(exitRect == true)
            {
                r.DrawPolygon(g, rectPos.X, rectPos.Y, colorRect);
            }

            if(exitCircle == true)
            {
                c.DrawPolygon(g, circlePos.X, circlePos.Y, colorCircle);
            }

            if(exitTriangle == true)
            {
                t.DrawPolygon(g, circlePos.X, circlePos.Y, colorCircle);
            }
        }

        private void MouseDown_Click(object sender, MouseEventArgs e)
        {
            if ((e.X >= rectPos.X && e.Y <= rectPos.X + r.sizeWidth()) && (e.Y >= rectPos.Y && e.Y <= rectPos.Y + r.sizeHeight()) && moveCircle == false && exitRect == true)
            {
                fixMouse.X = e.X - rectPos.X;
                fixMouse.Y = e.Y - rectPos.Y;
                moveRect = true;
            }

            if((e.X >= circlePos.X && e.Y <= circlePos.X+c.sizeWidth()) && (e.Y>= circlePos.Y && e.Y <= circlePos.Y + c.sizeHeight()) && moveRect == false && exitCircle == true)
            {
                fixMouse.X = e.X - circlePos.X;
                fixMouse.Y = e.Y - circlePos.Y;
                moveCircle = true;
            }
        }

        private void MouseUp_Click(object sender, MouseEventArgs e)
        {
            if(moveRect == true)
            {
                moveRect = false;
            }

            if(moveCircle == true)
            {
                moveCircle = false;
            }
        }

        private void MouseMove_Click(object sender, MouseEventArgs e)
        {
            if(moveRect == true)
            {
                MyPanel.Invalidate();
                rectPos.X = e.X - fixMouse.X;
                rectPos.Y = e.Y - fixMouse.Y;
                MyPanel.Invalidate();
            }

            if(moveCircle == true)
            {
                MyPanel.Invalidate();
                circlePos.X = e.X - fixMouse.X;
                circlePos.Y = e.Y - fixMouse.Y;
            }
        }

        private void RectangleColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                colorRect = colorDialog.Color;
                MyPanel.Invalidate();
            }
                
        }

        private void CircleColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                colorCircle = colorDialog.Color;
                MyPanel.Invalidate();
            }
        }

        private void Triangle_Click(object sender, EventArgs e)
        {
            Triangle.Checked = !Triangle.Checked;
            if (Triangle.Checked == true)
            {
                exitTriangle = true;
                MyPanel.Invalidate();
            }
            else
            {
                exitTriangle = false;
                MyPanel.Invalidate();
            }
        }
    }
}
