using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class Electrocasnice : Produs
    {
        [JsonProperty("Clasadeenergie")]
        internal string ClasadeEnergie { get; set; }
        [JsonProperty("Puteremaxima")]
        internal int PutereMaxima { get; set; }
        public Electrocasnice(string nume, float pret,int stoc, string clasadeEnergie, int putereMaxima) : base(nume, pret,stoc)
        {
            ClasadeEnergie = clasadeEnergie;
            PutereMaxima = putereMaxima;
        }
    }
}

