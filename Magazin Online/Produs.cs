using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class Produs
    {
        [JsonProperty("Nume")]
        internal string nume { get; set; }
        [JsonProperty("Pret")]
        internal float pret { get; set; }
        [JsonProperty("Stoc")]
        internal int stoc { get; set; }

        public Produs(string nume, float pret,int stoc)
        {
            this.nume = nume;
            this.pret = pret;
            this.stoc = stoc;
        }
    }
}
