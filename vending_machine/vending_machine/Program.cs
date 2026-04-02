using System;
using vending_machine;

class Program
{
    static void Main(string[] args)
    {
        VendingMachine machine = new VendingMachine();
        bool running = true;

        while (running)
        {
            //produkter
            Console.WriteLine("\n--- marcus vending machine ---");
            Console.WriteLine("1. Stoppa in pengar");
            Console.WriteLine("2. Visa produkter");
            Console.WriteLine("3. Köp produkt");
            Console.WriteLine("4. Avsluta");
            Console.Write("Val: ");

            string choice = Console.ReadLine();

            //switch case beroende på vilket val du gör
            switch (choice)
            {
                case "1":
                    Console.Write("Ange belopp (5, 10, 20, 50): ");
                    int money = int.Parse(Console.ReadLine());
                    machine.InsertMoney(money);
                    break;

                case "2":
                    machine.ShowProducts();
                    break;

                case "3":
                    Console.Write("Välj produktnummer: ");
                    int productNumber = int.Parse(Console.ReadLine());
                    machine.Purchase(productNumber);
                    break;

                case "4":
                    machine.EndTransaction();
                    running = false;
                    break;

                default:
                    Console.WriteLine("Ogiltigt val!");
                    break;
            }
        }
    }
}