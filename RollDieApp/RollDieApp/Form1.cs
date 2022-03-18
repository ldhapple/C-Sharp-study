using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RollDieApp
{
    public partial class Form1 : Form
    {
        private Random randomNumber = new Random();
        private int one, two, three, four, five, six;

        public Form1()
        {
            InitializeComponent();
        }

        public void DisplayDie(Label dieLabel)
        {
            int face = randomNumber.Next(1, 7);
            dieLabel.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\Images\\die" + face + ".gif");

            switch(face)
            {
                case 1:
                    one++;
                    break;

                case 2:
                    two++;
                    break;

                case 3:
                    three++;
                    break;

                case 4:
                    four++;
                    break;

                case 5:
                    five++;
                    break;

                case 6:
                    six++;
                    break;
            }
        }

        private void rollButton_Click(object sender, EventArgs e)
        {
            dieLabel1.Text = ""; DisplayDie(dieLabel1);
            dieLabel2.Text = ""; DisplayDie(dieLabel2);
            dieLabel3.Text = ""; DisplayDie(dieLabel3);
            dieLabel4.Text = ""; DisplayDie(dieLabel4);
            dieLabel5.Text = ""; DisplayDie(dieLabel5);
            dieLabel6.Text = ""; DisplayDie(dieLabel6);
            dieLabel7.Text = ""; DisplayDie(dieLabel7);
            dieLabel8.Text = ""; DisplayDie(dieLabel8);
            dieLabel9.Text = ""; DisplayDie(dieLabel9);
            dieLabel10.Text = ""; DisplayDie(dieLabel10);
            dieLabel11.Text = ""; DisplayDie(dieLabel11);
            dieLabel12.Text = ""; DisplayDie(dieLabel12);

            double total = one + two + three + four + five + six;

            displayTextBox.Text =
                "Face\t\tFrequency\tPercent\n1\t\t" + one + "\t\t" +
                String.Format("{0:F2}", one / total * 100) + "%\n2\t\t" + two + "\t\t" +
                String.Format("{0:F2}", two / total * 100) + "%\n3\t\t" + three + "\t\t" +
                String.Format("{0:F2}", three / total * 100) + "%\n4\t\t" + four + "\t\t" +
                String.Format("{0:F2}", four / total * 100) + "%\n5\t\t" + five + "\t\t" +
                String.Format("{0:F2}", five / total * 100) + "%\n6\t\t" + six + "\t\t" +
                String.Format("{0:F2}", six / total * 100) + "%";
        }
    }
}
