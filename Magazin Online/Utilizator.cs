﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json;

namespace Proiect
{
    internal class Utilizator
    {
        private List<Produs> produse = new List<Produs>();
        private List<Produs> cos = new List<Produs>();
        private List<Comanda> comand = new List<Comanda>();
        public void SetProduse(List<Produs> produseAdmin)
        {
            produse = produseAdmin;
        }
        internal void VizualizareProduse()
        {
            foreach (var p in produse)
            {
                Console.WriteLine(p.nume + " " + p.stoc + " " + p.pret);
            }
        }
        internal void CautareProduse(string nume)
        {
            foreach (var p in produse)
            {
                if (nume == p.nume)
                    Console.WriteLine($"Produsul {p.nume} a fost gasit!");
                else
                    Console.WriteLine("Produsul nu a fost gasit.");
            }
        }
        internal void PlaceOrder()
        {
            Console.Write("Nume: ");
            string name = Console.ReadLine();
            Console.Write("Telefon: ");
            string phone = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Adresa: ");
            string address = Console.ReadLine();

            var comanda_noua = new Comanda(comand.Count + 1, name, phone, email, address);
            comand.Add(comanda_noua);
            Console.WriteLine("Comanda a fost plasata cu succes!");
        }
        internal void SortareDupaPret(int ordonare)
        {
            switch (ordonare)
            {
                case 1:
                    produse.Sort((s1, s2) => s1.pret.CompareTo(s2.pret));
                    foreach (var p in produse)
                    {
                        Console.WriteLine(p.nume);
                    }
                    break;
                case 2:
                    produse.Sort((s1, s2) => s2.pret.CompareTo(s1.pret));
                    foreach (var p in produse)
                    {
                        Console.WriteLine(p.nume);
                    }
                    break;
            }
        }
        internal void AdaugareCos(string nume)
        {
            foreach (var p in produse)
            {
                if (nume == p.nume)
                {
                    cos.Add(p);
                    Console.WriteLine("Produsul adaugat cu succes in cos");
                }
                else
                    Console.WriteLine("Produsul nu a fost gasit.");
            }
        }
        public void SaveData()
        {
            foreach (var p in produse)
            {
                File.WriteAllText("./store.json", JsonConvert.SerializeObject(p));
            }
        }


        public void LoadData()
        {
            if (File.Exists("./store.json"))
            {

                produse.Add(JsonConvert.DeserializeObject<Produs>(File.ReadAllText("./store.json")));
            }
            else
                produse = new List<Produs>();
        }
    }
}
