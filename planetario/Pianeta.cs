using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace planetario
{
    internal class Pianeta
    {
        public float Massa { get; set; }
        public Vettore Posizione { get; set; }// rispetto all'origine
        public Vettore Velocita { get; set; }
        public Vettore Accelerazione { get; set; }
        // public Vettore ForzaG { get; set; }// forza gravitazionale
        

    }
}
