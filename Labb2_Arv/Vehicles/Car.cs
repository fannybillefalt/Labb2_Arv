using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_Arv
{
    internal class Car : Vehicle
    {
        public int Doors { get; set; } = 4;

        public Car(string name, string brand, string model, string color, int price, int doors) :base(name, brand, model, color, price)
        {
            Doors = doors;
        }

        public void startEngine()
        {
            Console.WriteLine("vrrrrooooom");
        }
        public bool Refuel()
        {
            return false;
        }
    }
}
