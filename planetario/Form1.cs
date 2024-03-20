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
            Pianeta R = new Pianeta(Massa, Velocita, Posizione, Raggio);
            listBox1.Items.Add(R);
          
            

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


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            DisegnaPianeti();
            planetario.Move();
            


        }

        private void DisegnaPianeti()
        {
            Graphics g=this.CreateGraphics();
            foreach (Pianeta p in planetario.Pianeti)
            {
               
                g.FillEllipse(Brushes.Black, (float)(((p.Posizione.X))/1e2), (float)(((p.Posizione.Y))/1e2), p.Raggio, p.Raggio);//raggio
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
