using Drinks_Machine.DrinksMachine;
using System.Collections.Generic;

namespace DrinksMachines
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine coffee = new CoffeeMachine("Nespresso", 1800, "Home", "Cheapest");
            coffee.milkpod = new DrinksMachine.Accessories.MilkPod(300);
           


            SodaMachine sode = new SodaMachine("DewDuster", 4200, "Fun Zone", "Double Dew Delight");


            List<DrinksMachine> machines = new List<DrinksMachine>();

        }
    }
}
