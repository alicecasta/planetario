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
        Planetario planetario;

        public Form1()
        {
            InitializeComponent();


            planetario = new Planetario();
            planetario.Pianeti = new List<Pianeta> () ;
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Vettore Posizione = Vettore.Parse(textBox1.Text);
            Vettore Velocita = Vettore.Parse(textBox2.Text);
            float Massa=float.Parse(textBox3.Text);
            float Raggio=float.Parse(textBox5.Text); 
            string Nome=textBox4.Text;
            Pianeta R = new Pianeta(Nome, Posizione,Velocita, Raggio,Massa);
            listBox1.Items.Add(R);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();


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
            foreach (Pianeta p in listBox1.Items)
            {
                planetario.Pianeti.Add(p);
            }
            timer1.Enabled = true;
            textBox1.Visible = false;
            textBox2.Visible= false;
            textBox3.Visible= false;
            textBox4.Visible = false;   
            textBox5.Visible= false;
            label1.Visible=false;
            label2.Visible=false;
            label3.Visible=false;
            label4.Visible=false;
            label5.Visible=false;
            button1.Visible=false;
            button2.Visible=false;
            label6.Visible=false;
            button3.Visible=false;
            listBox1.Visible=false;
            BackColor = Color.MidnightBlue;
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            DisegnaPianeti();

            for (int i = 0; i < 1000; i++)
            {
                planetario.Move();
            }
            DisegnaStelline();

        }

        private void DisegnaStelline()
        {
            Graphics g = this.CreateGraphics();
            g.FillEllipse(Brushes.Yellow, 300, 200, 5, 5);
            g.FillEllipse(Brushes.Yellow, 600, 500, 5, 5);
            g.FillEllipse(Brushes.Yellow, 100, 100, 5, 5);
            g.FillEllipse(Brushes.Yellow, 50, 60, 5, 5);
            g.FillEllipse(Brushes.Yellow, 800, 200, 5, 5);
            g.FillEllipse(Brushes.Yellow, 100, 200, 5, 5);
            g.FillEllipse(Brushes.Yellow, 650, 100, 5, 5);
            g.FillEllipse(Brushes.Yellow, 460, 200, 5, 5);
            g.FillEllipse(Brushes.Yellow, 689, 432, 5, 5);
            g.FillEllipse(Brushes.Yellow, 100, 600, 5, 5);
            g.FillEllipse(Brushes.Yellow, 200, 400, 5, 5);
            g.FillEllipse(Brushes.Yellow, 600, 300, 5, 5);
            g.FillEllipse(Brushes.Yellow, 400, 500, 5, 5);
            g.FillEllipse(Brushes.Yellow, 280, 460, 5, 5);
            g.FillEllipse(Brushes.Yellow, 1340, 480, 5, 5);
            g.FillEllipse(Brushes.Yellow, 100, 360, 5, 5);
            g.FillEllipse(Brushes.Yellow, 1230, 560, 5, 5);
            g.FillEllipse(Brushes.Yellow, 260, 200, 5, 5);
            g.FillEllipse(Brushes.Yellow, 489, 992, 5, 5);
            g.FillEllipse(Brushes.Yellow, 1200, 600, 5, 5);
            g.FillEllipse(Brushes.Yellow, 100, 100, 5, 5);
            g.FillEllipse(Brushes.Yellow, 300, 200, 5, 5);
            g.FillEllipse(Brushes.Yellow, 950, 500, 5, 5);
            g.FillEllipse(Brushes.Yellow, 200, 400, 5, 5);
            g.FillEllipse(Brushes.Yellow, 1000, 650, 5, 5);
            g.FillEllipse(Brushes.Yellow, 1300, 200, 5, 5);
            g.FillEllipse(Brushes.Yellow, 170, 300, 5, 5);
            g.FillEllipse(Brushes.Yellow, 1560, 500, 5, 5);
            g.FillEllipse(Brushes.Yellow, 140, 102, 5, 5);
            g.FillEllipse(Brushes.Yellow, 200, 300, 5, 5);
            g.FillEllipse(Brushes.Yellow, 1400, 650, 5, 5);
            g.FillEllipse(Brushes.Yellow, 1240, 120, 5, 5);
            g.FillEllipse(Brushes.Yellow, 1470, 500, 5, 5);
            g.FillEllipse(Brushes.Yellow, 1560, 400, 5, 5);
            g.FillEllipse(Brushes.Yellow, 1220, 102, 5, 5);
            g.FillEllipse(Brushes.Yellow, 1407, 380, 5, 5);
            g.FillEllipse(Brushes.Yellow, 980, 650, 5, 5);
            g.FillEllipse(Brushes.Yellow, 670, 400, 5, 5);
            g.FillEllipse(Brushes.Yellow, 700, 460, 5, 5);
            g.FillEllipse(Brushes.Yellow, 560, 500, 5, 5);
            g.FillEllipse(Brushes.Yellow, 760, 476, 5, 5);
            g.FillEllipse(Brushes.Yellow, 600, 700, 5, 5);
            g.FillEllipse(Brushes.Yellow, 600, 750, 5, 5);
            g.FillEllipse(Brushes.Yellow, 540, 670, 5, 5);
            g.FillEllipse(Brushes.Yellow, 670, 650, 5, 5);
            g.FillEllipse(Brushes.Yellow, 4700, 720, 5, 5);
            g.FillEllipse(Brushes.Yellow, 340, 592, 5, 5);
            g.FillEllipse(Brushes.Yellow, 660, 800, 5, 5);
            g.FillEllipse(Brushes.Yellow, 1000, 350, 5, 5);
            g.FillEllipse(Brushes.Yellow, 1100, 320, 5, 5);
            g.FillEllipse(Brushes.Yellow, 1170, 300, 5, 5);
            g.FillEllipse(Brushes.Yellow, 1070, 290, 5, 5);
            g.FillEllipse(Brushes.Yellow, 1101, 400, 5, 5);
            g.FillEllipse(Brushes.Yellow, 1080, 390, 5, 5);
            g.FillEllipse(Brushes.Yellow, 1300, 700, 5, 5);
            g.FillEllipse(Brushes.Yellow, 1270, 790, 5, 5);
            g.FillEllipse(Brushes.Yellow, 1401, 800, 5, 5);
            g.FillEllipse(Brushes.Yellow, 1480, 690, 5, 5);
        }
        private void DisegnaPianeti()
        {
            Graphics g=this.CreateGraphics();
            foreach (Pianeta p in planetario.Pianeti)
            {
               
                g.FillEllipse(Brushes.Black, (float)(p.Posizione.X), (float)(Height -p.Posizione.Y), p.Raggio, p.Raggio);//raggio
            }


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
