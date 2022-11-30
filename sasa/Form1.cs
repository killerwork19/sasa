using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sasa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double p1 = double.Parse(textBox1.Text);
            double p2 = double.Parse(textBox2.Text);
            double p3 = double.Parse(textBox3.Text);
            double p4 = double.Parse(textBox4.Text);
            double p5 = double.Parse(textBox5.Text);
            double p6 = double.Parse(textBox6.Text);
            double p7 = double.Parse(textBox7.Text);
            double p8 = double.Parse(textBox8.Text);

            double h1 = p1 * p5 + p2 * p4;
            double h2 = p3 * p5 + p2 * p6;
            double h3 = p1 * p6 + p3 * p4;
            double zxa = h2 + h1;
            double zxb = h3 + h1;

            textBox9.Text = Convert.ToString(Math.Round(zxa, 2));
            textBox10.Text = Convert.ToString(Math.Round(zxb, 2));
            double da = zxa * p7;
            double da1 = zxb * p8;
            double da2 = da + da1;
            textBox11.Text = Convert.ToString(Math.Round(da2, 2));
        }
    }
}
