using System;
using System.Collections.Generic;
using System.Text;

namespace vending_machine
{
    public class Drink : Product
    {
        //hämtar bas klassen
        public Drink(string name, int price) : base(name, price)
        {
        }

        //override på bas produkten på hur du använder den
        public override string Use()
        {
            return $"Du dricker {Name}";
        }
    }
}
