using System;
using System.Collections.Generic;
using System.Text;

namespace vending_machine
{
    public class Snack : Product
    {
        //hämtar bas klassen
        public Snack(string name, int price) : base(name, price)
        {
        }

        //override på bas produkten på hur du använder den
        public override string Use()
        {
            return $"Du äter {Name}";
        }
    }
}
