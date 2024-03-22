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
        const double Tempo = 0.000001;

       
        public void Move()
        {
            foreach (Pianeta P in Pianeti)
            {
                P.forzag = new Vettore(0, 0);
                foreach (Pianeta p in Pianeti)
                {
                    if (P != p)
                    {
                        Vettore d = p.Posizione - P.Posizione;
                        double moduloF = G * (p.Massa * P.Massa) / (d.modulo() * d.modulo());
                        p.forzag = d.versore() * moduloF;
                    }
                }
                P.Accelerazione = P.forzag / P.Massa;

                P.Posizione = P.Posizione + (P.Velocita * Tempo) + (( P.Accelerazione * Math.Pow(Tempo, 2)*0.5));
                P.Velocita = P.Velocita + (P.Accelerazione * Tempo);
            }
        }
      
    }
}