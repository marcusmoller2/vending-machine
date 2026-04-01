using System;
using System.Collections.Generic;
using System.Text;

namespace vending_machine
{
    public class Drink : Product
    {
        public Drink(string name, int price) : base(name, price)
        {
        }

        public override string Use()
        {
            return $"Du dricker {Name}";
        }
    }
}
