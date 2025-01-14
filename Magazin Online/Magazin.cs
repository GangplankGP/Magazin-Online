using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class Magazin
    {
        private List<Produs> produse = new List<Produs>();
        private List<Comanda> comand = new List<Comanda>();
        internal void AdaugareProdus(Produs produs)
        {
            produse.Add(produs);
        }
        internal void ScoateProdus(Produs produs)
        {
            produse.Remove(produs);
        }
        internal List<Produs> VizualizareProduse()
        {
            return produse;
        }
        internal void SchimbareStoc(Produs produs,int cantitate) 
        {
            produs.stoc = cantitate;
        } 
        internal void ProcesareComanda(Comanda comenzi)
        {
            comand.Add(comenzi);
            Comanda.statut = "in curs de livrare";
        }
        internal List<Comanda> VizualizareComenzi()
        {
            return comanda;
        }
    }
}

