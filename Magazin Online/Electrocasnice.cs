using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class Electrocasnice : Produs
    {
        internal string ClasadeEnergie { get; private set; }
        internal int PutereMaxima { get; private set; }
        public Electrocasnice(string nume, decimal pret,int stoc, string clasadeEnergie, int putereMaxima) : base(nume, pret,stoc)
        {
            ClasadeEnergie = clasadeEnergie;
            PutereMaxima = putereMaxima;
        }
    }
}

