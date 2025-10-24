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

        public override void PrintInfo()
        {
            Console.WriteLine($"Ägare: {Owner}\n" +
                $"Märke: {Brand}\n" +
                $"Modell: {Model}\n" +
                $"Färg: {Color}\n" +
                $"Pris: {Price}\n" +
                $"Last: {MaxLoad}\n");
        }
        public override void Drive()
        {
            Console.WriteLine($"Nu kör {Owner} iväg med lasten!\n");
        }
        public override void startEngine()
        {
            Console.WriteLine($"{Owner}s lastbil låter brumm-brumm\n");
        }

        public bool Load(int currentLoad)
        {
            if (currentLoad > MaxLoad)
            {
                Console.WriteLine("App, app, app, du har lastat för mycket. Överlastsavgift: 2000 kr\n");
                return false;
            }
            else
            {
                Console.WriteLine($"Lasten är {currentLoad} kg. Yayy, inte för mycket."); this.Drive();

                return true;
            }

            
        }
    }
}
