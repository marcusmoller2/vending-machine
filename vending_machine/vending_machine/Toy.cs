using System;
using System.Collections.Generic;
using System.Text;

namespace vending_machine
{
    public class Toy : Product
    {
        public Toy(string name, int price) : base(name, price)
        {
        }

        public override string Use()
        {
            return $"Du leker med {Name}";
        }
    }
}
