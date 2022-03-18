using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace gugudanApp
{
    public partial class Form1 : Form
    {
        ArrayList myArrayList = new ArrayList();
        gugudanDLL.GugudanClass gugudan = new gugudanDLL.GugudanClass();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*myArrayList = gugudan.Print();
            for(int i=0; i<myArrayList.Count; i++)
            {
                listBox1.Items.Add(myArrayList[i]);
            }*/
            int start, end;

            start = Int32.Parse(textBox1.Text);
            end = Int32.Parse(textBox2.Text);

            if(start >= end)
            {
                MessageBox.Show("시작단이 끝단보다 작아야합니다.");
            }

            myArrayList = gugudan.Print2(start,end);
            for (int i = 0; i < myArrayList.Count; i++)
            {
                listBox1.Items.Add(myArrayList[i]);
            }
            
        }
    }
}
