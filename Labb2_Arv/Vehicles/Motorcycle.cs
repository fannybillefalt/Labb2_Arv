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


        public override void startEngine()
        {
            Console.WriteLine("brrrapp, brrrraaaappppp");
        }
        public void OnSale()
        {
            Console.WriteLine($"{Owner} {Brand} är på REA!");
            Price -= 500;

        }
    }
}
