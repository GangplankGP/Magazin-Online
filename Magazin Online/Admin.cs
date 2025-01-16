using Newtonsoft.Json;
using Proiect;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class Admin
    {
        private string PathProduse = Directory.GetCurrentDirectory() + "\\ListaProduse.json";
        private string PathComenzi = Directory.GetCurrentDirectory() + "\\ListaComenzi.json";
        private List<Produs> produse = new List<Produs>();
        private List<Comanda> comand = new List<Comanda>();

        public List<Produs> GetProduse()
        {
            return produse;
        }
        internal void AdaugareProdus()
        {
            Console.Write("Nume produs: ");
            string nume = Console.ReadLine();
            Console.Write("Pret: ");
            float pret = float.Parse(Console.ReadLine());
            Console.Write("Stoc: ");
            int stoc = int.Parse(Console.ReadLine());
            Console.Write("Alegeti tipul produsului: ");
            Console.WriteLine("1. Generic");
            Console.WriteLine("2. Perisabil");
            Console.WriteLine("3. Electrocasnic");
            string opt = Console.ReadLine();

            switch (opt)
            {
                case "1":
                    Produs prod1 = new Produs(nume, pret, stoc);
                    produse.Add(prod1);
                    Console.WriteLine("Produs adaugat cu succes!");
                    break;
                case "2":
                    Console.Write("Data expirarii (DD-MM-YYYY): ");
                    DateTime dataexp = DateTime.Parse(Console.ReadLine());
                    Console.Write("Conditii de pastrare: ");
                    string conditii = Console.ReadLine();
                    Produs prod2 = new ProdusPerisabil(nume, pret, stoc, dataexp, conditii);
                    produse.Add(prod2);
                    Console.WriteLine("Produs adaugat cu succes!");
                    break;
                case "3":
                    Console.Write("Clasa de eficienta energetica (de la A la G): ");
                    string clasa = Console.ReadLine();
                    Console.Write("Putere maxima consumata ");
                    int pwr = Int32.Parse(Console.ReadLine());
                    Produs prod3 = new Electrocasnice(nume, pret, stoc, clasa, pwr);
                    produse.Add(prod3);
                    Console.WriteLine("Produs adaugat cu succes!");
                    return;
                default:
                    Console.WriteLine("Optiune invalida!");
                    break;
            }
        }
        internal void ScoateProdus(string nume_produs)
        {
            foreach (var p in produse)
            {
                if (p.nume == nume_produs)
                {
                    produse.Remove(p);
                    Console.WriteLine("Produsul a fost eliminat din stoc cu succes!");
                    return;
                }
            }
            Console.WriteLine("Produsul nu a fost gasit!");
        }
        internal void SchimbareStoc(string nume_produs, int cantitate)
        {
            foreach (var p in produse)
            {
                if (p.nume == nume_produs)
                {
                    p.stoc = cantitate;
                    Console.WriteLine("Stoc actualizat cu succes!");
                    return;
                }
                    
            }
            Console.WriteLine("Produsul nu a fost gasit.");
        }
        internal void ProcesareComanda(int id)
        {
            foreach (var com in comand)
            {
                if (com.OrderId == id)
                {
                    Console.WriteLine($"Lista Comenzi: Numarul comenzii: {com.OrderId}, Client: {com.CustomerName}, Status: {com.Status}, Data livrare: {com.DeliveryDate}");
                    Console.WriteLine("Introdu data livrarii (DD-MM-YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    com.editare_admin(date);
                }


            }
        }
        internal void VizualizareComenzi()
        {
            foreach (var com in comand)
            {
                string stare = com.DeliveryDate < DateTime.Now ? "livrat" : com.Status;
                Console.WriteLine($"Lista Comenzi: Numarul comenzii: {com.OrderId}, Client: {com.CustomerName}, Status: {stare}, Data livrare: {com.DeliveryDate}");
            }
        }
        public void SaveDataProd()
        {
            string produseJSON = JsonConvert.SerializeObject(this.produse, Formatting.Indented);
            File.WriteAllText("ListaProduse.json", produseJSON);
        }
        public void SaveDataCom()
        {
            string comenziJSON = JsonConvert.SerializeObject(this.comand, Formatting.Indented);
            File.WriteAllText("ListaComenzi.json", comenziJSON);
        }


        public void LoadDataProd()
        {
            if (File.Exists(PathProduse))
            {
                string jsonstr = File.ReadAllText(PathProduse);
                var result = JsonConvert.DeserializeObject<List<Produs>>(jsonstr);
                if (result == null)
                    this.produse = new List<Produs>();
                else
                {
                    foreach (var prod in result)
                    {
                        this.produse.Add(prod);
                    }
                }
            }
            else
            {
                this.produse = new List<Produs>();
            }
        }
        public void LoadDataCom()
        {
            if (File.Exists(PathComenzi))
            {
                try
                {
                    string jsonstr = File.ReadAllText(PathComenzi);
                    var result = JsonConvert.DeserializeObject<List<Comanda>>(jsonstr);
                    if (result == null)
                        this.comand = new List<Comanda>();
                    else
                    {
                        foreach (var prod in result)
                        {
                            this.comand.Add(prod);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                this.comand = new List<Comanda>();
            }
        }
    }
}
