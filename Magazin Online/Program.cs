namespace Proiect
{
    class Program
    {
        static bool checkpass(string input)
        {
            string password = "admin";
            if (input == password)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            //Store store = Store.LoadData();
            Admin admin = new Admin();
            Utilizator utilizator = new Utilizator();

            while (true)
            {
                Console.WriteLine("1. Utilizator");
                Console.WriteLine("2. Administrator");
                Console.WriteLine("3. Iesire");
                Console.Write("Alege optiunea: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        UserMenu(utilizator, admin);
                        break;
                    case "2":
                        Console.WriteLine("Introdu parola: ");
                        string input = Console.ReadLine();
                        if (checkpass(input))
                            AdminMenu(admin);
                        else
                            Console.WriteLine("Nu aveti permisiunea de Admin!");
                        break;
                    case "3":
                        //store.SaveData();
                        return;
                    default:
                        Console.WriteLine("Optiune invalida!");
                        break;
                }
            }
        }


        static void UserMenu(Utilizator utilizator, Admin admin)
        {
            while (true)
            {
                Console.WriteLine("1. Vizualizare produse");
                Console.WriteLine("2. Cauta produs");
                Console.WriteLine("3. Sorteaza produse dupa pret");
                Console.WriteLine("4. Adauga produs in cos");
                Console.WriteLine("5. Plaseaza comanda");
                Console.WriteLine("6. Inapoi");
                Console.Write("Alege optiunea: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        utilizator.SetProduse(admin.GetProduse());
                        utilizator.VizualizareProduse();
                        break;
                    case "2":
                        Console.Write("Introdu numele produsului: ");
                        string name = Console.ReadLine();
                        utilizator.CautareProduse(name);
                        break;
                    case "3":
                        Console.Write("1. Crescator, 2. Descrescator: ");
                        int ord = Convert.ToInt32(Console.ReadLine());
                        utilizator.SortareDupaPret(ord);
                        break;
                    case "4":
                        Console.Write("Introdu nume produs: ");
                        string nume = Console.ReadLine();
                        //utilizator.AddToCart(nume);
                        break;
                    case "5":
                        utilizator.PlaceOrder();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Optiune invalida!");
                        break;
                }
            }
        }

        static void AdminMenu(Admin admin)
        {
            while (true)
            {
                Console.WriteLine("1. Adauga produs nou");
                Console.WriteLine("2. Scoate produs");
                Console.WriteLine("3. Modifica stoc");
                Console.WriteLine("4. Vizualizare comenzi");
                Console.WriteLine("5. Proceseaza comenzi");
                Console.WriteLine("6. Inapoi");
                Console.Write("Alege optiunea: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        admin.AdaugareProdus();
                        break;
                    case "2":
                        Console.Write("Introdu numele produsului: ");
                        string id = Console.ReadLine();
                        admin.ScoateProdus(id);
                        break;
                    case "3":
                        Console.Write("Introdu nume produs: ");
                        string pid = Console.ReadLine();
                        Console.Write("Introdu cantitate noua: ");
                        int quantity = int.Parse(Console.ReadLine());
                        admin.SchimbareStoc(pid, quantity);
                        break;
                    case "4":
                        admin.VizualizareComenzi();
                        break;
                    case "5":
                        Console.Write("Introdu ID-ul comenzii: ");
                        int idc = Convert.ToInt32(Console.ReadLine());
                        admin.ProcesareComanda(idc);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Optiune invalida!");
                        break;
                }
            }
        }
    }
}
