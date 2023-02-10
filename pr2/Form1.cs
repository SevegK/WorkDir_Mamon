using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();   
        }

        private void HidePanels()
        {
            foreach (var control in Controls)
                if (control is Panel)
                    ((Panel)control).Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           int a = Convert.ToInt32(textBox1.Text);
           int b = Convert.ToInt32(textBox1.Text);
            int c = (a + b) / 2;
            label2.Text = Convert.ToString(c);
           
        }

        private void SetPan_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox3.Text);
            float z = float.Parse(textBox4.Text);
            float y = float.Parse(textBox5.Text);
            double f = Math.Pow(Math.Sqrt(y + Math.Pow(Math.Sqrt(x - 1), 4)), 3) / Math.Abs(x - y) * (Math.Pow(Math.Sin(z), 4) + Math.Tan(z));
            label7.Text = Convert.ToString(f);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void SetPan2_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
    }
}
