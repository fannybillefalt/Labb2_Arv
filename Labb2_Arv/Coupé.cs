using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv.Vehicles.Cars
{
    internal class Coupé : Car
    {
        public int MaximumSpeed { get; set; } = 250;
        public Coupé(string owner, string brand, string model, string color, int price, int doors, int fuel, int maximumspeed) : base(owner, brand, model, color, price, doors, fuel)
        {
            MaximumSpeed = maximumspeed;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Ägare: {Owner}\n" +
                $"Märke: {Brand}\n" +
                $"Modell: {Model}\n" +
                $"Färg: {Color}\n" +
                $"Pris: {Price}\n" +
                $"Antal dörrar: {Doors}\n" +
                $"Tankskala: {Fuel}\n" +
                $"Maxhastighet: {MaximumSpeed}\n");
        }
        public override void startEngine()
        {
            Console.WriteLine($"{Owner}s coupé låter Rrrrrrraaaam!\n");
        }
    }
}
