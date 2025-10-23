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

        public Truck(string name, string brand, string model, string color, int price, int maxload) : base(name, brand, model, color, price)
        {
            MaxLoad = maxload;
        }

        public void startEngine()
        {
            Console.WriteLine("brumm-brumm");
        }

        public void Unloading()
        {
            Console.WriteLine("PIP! PIP! PIP! Lastbilen lastar ur.");

        }
    }
}
