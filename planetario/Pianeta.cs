using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planetario
{
    internal class Pianeta
    {
        public Pianeta()
        {
        }

        
        public Pianeta(float massa, Vettore posizione, Vettore velocita,float raggio)
        {
            Massa = massa;
            Posizione = posizione;
            Velocita = velocita;
            Raggio=raggio;
           
        }

        public float Massa { get; set; }
        public Vettore Posizione { get; set; }//rispetto all'origine
        public Vettore Velocita { get; set; }
        public Vettore Accelerazione { get; set; }
        
        public float Raggio { get; set; }   
        internal void forzag(Pianeta p2)
        {
            throw new NotImplementedException();
        }
        // public Vettore ForzaG { get; set; }// forza gravitazionale
        public override string ToString()
        {
            return string.Format;
        }

    }
}
