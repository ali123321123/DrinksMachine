using System;
using System.Collections.Generic;
using System.Text;


namespace Drinks_Machine.DrinksMachine
{
    class SodaMachine : DrinksMachine
    {
        public string Flavour { get; set; }

        public SodaMachine(): base()
        {

        }

        public SodaMachine(string brand, double price, string location,string flavour): base(brand,price,location)
        {
            Flavour = flavour;
        }

        public override void Clean()
        {
            Console.WriteLine("Get Chad To come clean the sode machine");
        }

        public override void MakeDrink()
        {
            Console.WriteLine("Spwwing out that necter, which testes like "+Flavour);
        }
    }
}
