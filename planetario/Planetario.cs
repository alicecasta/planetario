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

        public Planetario() { Pianeti = new List<Pianeta>(); }



        public List<Pianeta> Pianeti { get; set; }
        
       
        const double G= 6.673e-11;
        const double Tempo = 0.0001;

       
        public void Move()
        {
            
            foreach (Pianeta p in Pianeti)
            {
                
                p.Accelerazione = Forza(p) / p.Massa;
               
                p.Posizione = p.Posizione + (p.Velocita * Tempo) + ((p.Accelerazione * Math.Pow(Tempo, 2)) * 0.5);
                p.Velocita = p.Velocita + p.Accelerazione * Tempo;
            }
        }
        public Vettore forzag(Pianeta p1, Pianeta p2)
        {
            Vettore d = p1.Posizione-p2.Posizione;
            double moduloF= G * (p1.Massa * p2.Massa) / (d.modulo()*d.modulo());  
            Vettore f = d.versore()*moduloF;
            return f;
        }

        public Vettore Forza(Pianeta p)
        {
            Vettore vettore = new Vettore(0,0);


            foreach (var p2 in Pianeti)
            {
                if (p != p2)
                {
                    vettore= vettore+forzag(p, p2);
                }
                else if (p == p2)
                {
                    return vettore;
                }
            }
            return vettore;
        }
    }
}