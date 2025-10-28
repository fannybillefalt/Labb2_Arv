using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv
{
    internal class Car : Vehicle
    {
        //proporties
        public int Doors { get; set; } = 4;
        public int Fuel { get; set; } = 5;

        //constructor, using base to inherit from base class
        public Car(string owner, string brand, string model, string color, int price, int doors, int fuel) :base(owner, brand, model, color, price)
        {
            Fuel = fuel;
            Doors = doors;
        }
        //methods
        public override void startEngine()
        {
            Console.WriteLine($"{Owner}s bil låter vrrrrooooom\n");
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Ägare: {Owner}\n" +
                $"Märke: {Brand}\n" +
                $"Modell: {Model}\n" +
                $"Färg: {Color}\n" +
                $"Pris: {Price}\n" +
                $"Antal dörrar: {Doors}\n" +
                $"Tankskala: {Fuel}\n");
        }
        //depending on what fuel level the car have, different options is given.
        public bool Refuel()
        {
            if (Fuel >= 10)
            {
                Console.WriteLine($"{Owner}s {Brand} {Model} har redan full tank!");
                return false; // nothing to do
            }
            else if (Fuel >= 5)
            {
                Console.WriteLine($"{Owner}s {Brand} {Model} har halv tank. Du kanske vill tanka snart?");
            }
            else if (Fuel < 5)
            {
                Console.WriteLine($"{Owner}s {Brand} {Model} har låg bränslenivå! Tankar nu...");
                Fuel = 10;
                Console.WriteLine("Tanken är nu full!\n");
            }

            return true;
        }

    }
}

