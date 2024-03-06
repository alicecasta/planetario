using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace planetario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = textBox4.Text + " " + "(" + textBox1.Text + "," + textBox2.Text + "," + textBox3.Text+")";      
         if (textBox1.Text != null && textBox2.Text!=null && textBox3.Text != null)
            {
                listBox1.Items.Add(n);
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem!=null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Vettore a = new Vettore();
           a=Vettore.Parse(textBox1.Text);
            float m = float.Parse(textBox3.Text);
            Graphics p1 = this.CreateGraphics();
            p1.FillEllipse(Brushes.Black,(float) a.X, (float)a.Y, m, m);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}
