using System;
using System.Collections.Generic;
using System.Text;

namespace vending_machine
{
    public class VendingMachine
    {
        public List<Product> Products { get; set; }
        public int MoneyPool { get; set; }

        public VendingMachine()
        {
            //skapar lista av produkter
            Products = new List<Product>();
            MoneyPool = 0;

            Products.Add(new Drink("Cola", 25));
            Products.Add(new Drink("Fanta", 25));
            Products.Add(new Snack("Chips", 20));
            Products.Add(new Snack("Chocolate", 15));
            Products.Add(new Toy("Toy Car", 50));
            Products.Add(new Toy("Ball", 30));
            Products.Add(new Snack("Nuts", 10));
        }


        // sätter in pengar till ditt saldo
        public void InsertMoney(int amount)
        {
            if (amount == 5 || amount == 10 || amount == 20 || amount == 50)
            {
                MoneyPool += amount;
                Console.WriteLine($"Du stoppade in {amount} kr. Totalt: {MoneyPool} kr");
            }
            else
            {
                Console.WriteLine("Ogiltig");
            }
        }

        //visar produkterna
        public void ShowProducts()
        {
            Console.WriteLine("\nProdukter:");
            for (int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Products[i].Examine()}");
            }
        }

        //tittar så att valt nummer är ett möjligt val i listan
        public void Purchase(int productNumber)
        {
            if (productNumber < 1 || productNumber > Products.Count)
            {
                Console.WriteLine("Fel :(");
                return;
            }

            Product product = Products[productNumber - 1];

            //köper och använder vald produkt om du har råd
            if (MoneyPool >= product.Price)
            {
                MoneyPool -= product.Price;
                Console.WriteLine($"Du köpte: {product.Name}");
                Console.WriteLine(product.Use());
            }
            else
            {
                Console.WriteLine("Du har inte tillräckligt med pengar!");
            }
        }

        //ger tillbaka dina pengar och avslutar
        public void EndTransaction()
        {
            Console.WriteLine($"Du får tillbaka {MoneyPool} kr");
            MoneyPool = 0;
        }
    }
}
