using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Lapis
    {
        private string dureza;
        private bool apontado;
        private int percentualGrafite;
            
        public string Dureza
        {
            get { return dureza; }
            set { dureza = value; }

        }
        public bool Apontado
        {
            get { return apontado; }
            set { apontado = value; }
        }
        private  int PercentualGrafite
            {
            get { return percentualGrafite;}
            set { percentualGrafite = value; }
            }
        
        public Lapis(string dureza  )
        {
            Dureza = dureza;
            Apontado = true;
            PercentualGrafite = 100;

        }
        public void QuebrarPonta()
        {
            if (PercentualGrafite < 15) 
        }
    }
}
