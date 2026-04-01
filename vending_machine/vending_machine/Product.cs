using System;
using System.Collections.Generic;
using System.Text;

namespace vending_machine
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public virtual string Examine()
        {
            return $"{Name} - {Price} kr";
        }

        public virtual string Use()
        {
            return $"Du använder {Name}";
        }
    }
}
