using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv
{
    internal class Truck : Vehicle
    {
        public int MaxLoad { get; set; } = 600;

        public Truck(string owner, string brand, string model, string color, int price, int maxload) : base(owner, brand, model, color, price)
        {
            MaxLoad = maxload;
        }

        public void Drive()
        {
            Console.WriteLine($"Nu kör {Owner}");
        }
        public override void startEngine()
        {
            Console.WriteLine("brumm-brumm");
        }

        public void Unloading()
        {
            Console.WriteLine("PIP! PIP! PIP! Lastbilen lastar ur.");

        }
    }
}
