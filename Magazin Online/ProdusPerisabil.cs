using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class ProdusPerisabil : Produs
    {
        [JsonProperty("Dataexpirare")]
        internal DateTime DataExpirare { get; set; }
        [JsonProperty("Conditiedepastrare")]
        internal string ConditieDePastrare { get; set; }
        public ProdusPerisabil(string nume, float pret,int stoc,DateTime dataExpirare,string conditieDePastrare) : base(nume, pret,stoc)
        {
            DataExpirare = dataExpirare;
            ConditieDePastrare = conditieDePastrare;
        }
    }
}
