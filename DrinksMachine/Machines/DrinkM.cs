using System;
using System.Collections.Generic;
using System.Text;

namespace Drinks_Machine.DrinksMachine
{
   public abstract class DrinksMachine
    {
    public string Brand     { get; set; }
        public double  Price  { get; set; }
        public string Location { get; set; }

        //Constructores 
       protected DrinksMachine()
        {
            Brand = " No name";
        }

        protected DrinksMachine(string brand, double price, string location)
        {
            Brand = brand;
            Price = price;
            Location = location;
        }


        //Behaviors 

        public abstract void MakeDrink();
      public virtual  void Clean()
        {
            Console.WriteLine("Flsuhing water through the system ");
        }



    }
}
