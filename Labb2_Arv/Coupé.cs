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
        public Coupé(string name, string brand, string model, string color, int price, int doors, int seats, int maximumspeed) : base(name, brand, model, color, price, doors)
        {
            MaximumSpeed = maximumspeed;
        }
    }
}
