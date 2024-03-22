using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace planetario
{
    internal class Pianeta
    {
        public Pianeta()
        {
        }

        
        public Pianeta( string nome,Vettore posizione, Vettore velocita,float raggio, float massa)
        {
            Nome = nome;    
            Massa = massa;
            Posizione = posizione;
            Velocita = velocita;
            Raggio=raggio;
           
        }

        public float Massa { get; set; }
        public Vettore Posizione { get; set; }//rispetto all'origine
        public Vettore Velocita { get; set; }
        public Vettore Accelerazione { get; set; }
        public string Nome { get; set; }
        
        public float Raggio { get; set; }  
        public Vettore forzag {  get; set; }    
       
        public override string ToString()
        {
            return string.Format("{0}:({1}, {2}, {3}, {4})", Nome, Posizione, Velocita, Raggio, Massa);
        }

    }
}
