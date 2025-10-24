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
        public int Doors { get; set; } = 4;
        public int Fuel { get; set; } = 5;

        public Car(string owner, string brand, string model, string color, int price, int doors, int fuel) :base(owner, brand, model, color, price)
        {
            Fuel = fuel;
            Doors = doors;
        }

        public override void startEngine()
        {
            Console.WriteLine($"{ Owner}s bil låter vrrrrooooom\n");
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
        public bool Refuel()
        {
            if (Fuel >= 10)
            {
                Console.WriteLine($"{Owner}s {Brand} {Model} har redan full tank!");
                return false; // inget att göra
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

