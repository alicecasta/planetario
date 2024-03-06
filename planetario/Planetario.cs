using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planetario
{
    internal class Planetario
    {
        public List<Pianeta> Pianeti { get; set; }
        public double Tempo { get; set; } // delta t
        const double G= 6.673e-11;

       
        public void Move()
        {
            foreach (Pianeta pianeta in Pianeti)
            {

            }

        }
        public Vettore forzag(Pianeta p1, Pianeta p2)
        {
            Vettore d = p1.Posizione-p2.Posizione;
            double moduloF= G * (p1.Massa * p2.Massa) / (d.modulo()*d.modulo());  
            Vettore f = moduloF* d.versore();
            return f;
        }

        public Vettore Forza(Pianeta p)
        {

        }
    }
}