using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class Produs
    {
        internal string nume { get; private set; }
        internal decimal pret {  get; private set; }
        internal int stoc {  get; set; }

        public Produs(string nume, decimal pret,int stoc)
        {
            this.nume = nume;
            this.pret = pret;
            this.stoc = stoc;
        }
    }
}
