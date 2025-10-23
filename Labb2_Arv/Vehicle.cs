using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv
{
    internal class Vehicle
    {
        public string Name { get; set; } = "Okänt fordon";
        public string Brand { get; set; } = "Okänt märke";
        public string Model { get; set; } = "Okänd modell";
        public string Color { get; set; } = "Okänd färg";
        public int Price { get; set; } = 0;

        public Vehicle(string name, string brand, string model, string color, int price)
        {
            Name = name;
            Brand = brand;
            Model = model;
            Color = color;
            Price = price;

        }

        public virtual void Drive()
        {
            Console.WriteLine("Nu kör bilen!");
        }

        public void PumpingGas()
        {
            
        }

        public void Break()
        {
            Console.WriteLine("BROMSAAAAAAAA!");
        }

    }
}
