using System;
using System.Collections.Generic;
using System.Text;

namespace vending_machine
{
    public class Product
    {
        //hämtar och skickar namn och pris
        public string Name { get; set; }
        public int Price { get; set; }

        //skapar bas produkten (använder sin egna constructor)
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        // visar namn och pris för produkten
        public virtual string Examine()
        {
            return $"{Name} - {Price} kr";
        }

        //använder produkten, blir overriden i child classen
        public virtual string Use()
        {
            return $"Du använder {Name}";
        }
    }
}
