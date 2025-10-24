using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv
{
    internal class Motorcycle : Vehicle
    {
        public bool SideCar { get; set; } = false;

        public Motorcycle(string owner, string brand, string model, string color, int price, bool sidecar) : base(owner, brand, model, color, price)
        {
            SideCar = sidecar;
        }
        public override void PrintInfo()
        {
            string sidecar = SideCar ? "Ja, den har en sidovagn" : "Nej, ingen sidovagn!";
            Console.WriteLine($"Ägare: {Owner}\n" +
                $"Märke: {Brand}\n" +
                $"Modell: {Model}\n" +
                $"Färg: {Color}\n" +
                $"Pris: {Price}\n" +
                $"Sidorvagn: {sidecar}\n");
        }


        public override void startEngine()
        {
            Console.WriteLine($" {Owner}s motorcykel låter brrrapp, brrrraaaappppp\n");
        }
        public void OnSale()
        {
            Console.WriteLine($"{Owner} {Brand} är på REA! Nya priset är: {Price}\n");
            Price -= 500;

        }
    }
}
