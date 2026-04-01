using System;
using System.Collections.Generic;
using System.Text;

namespace vending_machine
{
    public class Snack : Product
    {
        public Snack(string name, int price) : base(name, price)
        {
        }

        public override string Use()
        {
            return $"Du äter {Name}";
        }
    }
}
