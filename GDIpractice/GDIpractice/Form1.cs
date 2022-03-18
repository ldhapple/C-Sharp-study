using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;
using System.Drawing.Drawing2D;

namespace GDIpractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Image newImage = Image.FromFile("TEST.JPG");

                e.Graphics.DrawImage(newImage, this.ClientRectangle);

                newImage.Dispose();


            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }






        }
    }
}
