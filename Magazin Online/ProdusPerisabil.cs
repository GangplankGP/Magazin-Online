using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class ProdusPerisabil : Produs
    {
        internal DateTime DataExpirare { get; private set; }
        internal string ConditieDePastrare { get; private set; }
        public ProdusPerisabil(string nume, float pret,int stoc,DateTime dataExpirare,string conditieDePastrare) : base(nume, pret,stoc)
        {
            DataExpirare = dataExpirare;
            ConditieDePastrare = conditieDePastrare;
        }
    }
}
