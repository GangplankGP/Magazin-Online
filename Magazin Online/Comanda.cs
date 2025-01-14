using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class Comanda
    {
        internal string nume {  get; private set; }
        internal string numardetelefon {  get; private set; }
        internal string email {  get; private set; }
        internal string adresa {  get; private set; }
        internal List<Produs> produse {  get; private set; }=new List<Produs>();
        internal string statut { get; private set; };

        public Comanda(string nume, string numardetelefon, string email, string adresa, List<Produs> produse)
        {
            this.nume = nume;
            this.numardetelefon = numardetelefon;
            this.email = email;
            this.adresa = adresa;
            this.produse = produse;
        }
    }
}
