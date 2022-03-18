using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Multi(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }
    }
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            switch(comboBox1.SelectedItem.ToString())
            {
                case "+":
                    textBox3.Text = Calculator.Plus(num1, num2).ToString();
                        break;
                case "-":
                    textBox3.Text = Calculator.Minus(num1, num2).ToString();
                    break;
                case "*":
                    textBox3.Text = Calculator.Multi(num1, num2).ToString();
                    break;
                case "/":
                    textBox3.Text = Calculator.Divide(num1, num2).ToString();
                    break;
            }
        }
    }
}
