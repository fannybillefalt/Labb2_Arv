using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv
{
    internal class Vehicle
    {
        //5 proporties with default value.
        public string Owner { get; set; } = "Okänd ägare";
        public string Brand { get; set; } = "Okänt märke";
        public string Model { get; set; } = "Okänd modell";
        public string Color { get; set; } = "Okänd färg";
        public int Price { get; set; } = 0;

        //constructor to create new vehicles
        public Vehicle(string owner, string brand, string model, string color, int price)
        {
            Owner = owner;
            Brand = brand;
            Model = model;
            Color = color;
            Price = price;
        }
        //methods 
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Ägare: {Owner}\n" +
                $"Märke: {Brand}\n" +
                $"Modell: {Model}\n" +
                $"Färg: {Color}\n" +
                $"Pris {Price}");
        }

        public virtual void startEngine()
        {
            Console.WriteLine("vrrrroooom");
        }

        public virtual void Drive()
        {
            Console.WriteLine($"Nu kör {Owner}");
        }

        public void Break()
        {
            Console.WriteLine($"{Owner}BROMSAAAAAAAAR!");
        }



    }
}
