﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class Comanda
    {
        internal int OrderId;
        internal List<Produs> Produse;
        internal string CustomerName;
        internal string PhoneNumber;
        internal string Email;
        internal string Address;
        internal string Status;
        internal DateTime DeliveryDate;

        internal Comanda(int orderid, string nume, string nrtel, string mail, string adresa)
        {
            OrderId = orderid;
            Produse = new List<Produs>();
            CustomerName = nume;
            PhoneNumber = nrtel;
            Email = mail;
            Address = adresa;
            Status = "In asteptare";
        }

        internal void editare_admin(DateTime date)
        {
            Console.WriteLine("Alegeti noul status al comenzii: ");
            Console.WriteLine("1. In asteptare ");
            Console.WriteLine("2. In curs de livrare ");
            string opt = Console.ReadLine();
            switch (opt)
            {
                case "1":
                    Status = "In asteptare";
                    break;
                case "2":
                    Status = "In curs de livrare";
                    break;
                default:
                    Console.WriteLine("Optiune invalida!");
                    break;
            }
            DeliveryDate = date;
            Console.WriteLine("Datele comenzii au fost actualizate!");
        }
    }
}
