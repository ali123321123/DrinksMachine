using DrinksMachine.Accessories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Drinks_Machine.DrinksMachine
{
    public class CoffeeMachine : DrinksMachine
    {
        public string BeanType { get; set; }
        public MilkPod milkpod { get; set; }

      public CoffeeMachine():base()
        {

        }

        public CoffeeMachine(string brand, double price, string location,string beanType):base(brand, price,location)
        {
            BeanType = beanType;
        }

        public override void MakeDrink()
        {
            Console.WriteLine("Beans are being roasted");
        }

        public override void Clean()
        {
            Console.WriteLine("Empty the grounds, then flush the system");
        }
    }
}
