using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Labb2_Arv
{
    internal class MiniBus : Car
    {
        public int Seats { get; set; } = 7;
        public MiniBus(string owner, string brand, string model, string color, int price, int doors, int seats) :base(owner, brand, model, color, price, doors)
        {

            Seats = seats;

        }

        public override void startEngine()
        {
            Console.WriteLine("vrummi vrummi");
        }

    }
}
