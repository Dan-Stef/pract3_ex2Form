using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract3_ex2Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double f(double x)
        {
            double y;
            if ((x * x + (2 * x) + 1) < 2)
                y = x * x;
            else if (((x * x + (2 * x) + 1) < 3 ) && ((x * x + (2 * x) + 1)) >= 2)
                y = 1 / (x * x - 1);
            else y = 0;
            return y;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double h = Convert.ToDouble(textBox3.Text);
            for (double i = a; i <= b; i += h)
            {
                textBox4.AppendText("y(" + i+ ")= "+ f(i));
                textBox4.AppendText(Environment.NewLine);
            }
        }
    }
}
