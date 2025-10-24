using Labb2_Arv.Vehicles.Cars;

namespace Labb2_Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Car car = new Car("Fanny", "Volvo", "V70", "Blå", 120000, 4, 3);
            Motorcycle mc = new Motorcycle("Ali", "Yamaha", "MT-07", "Svart", 70000, true);
            Truck truck = new Truck("Olle", "Scania", "R500", "Röd", 450000, 6000);
            MiniBus minibus = new MiniBus("Sara", "Volkswagen", "Transporter", "Vit", 250000, 5, 8);
            Coupé coupe = new Coupé("Lisa", "BMW", "M4", "Silver", 700000, 2, 4, 280);

            car.PrintInfo();
            car.startEngine();
            car.Refuel();

            mc.PrintInfo();
            mc.startEngine();
            mc.OnSale();

            truck.PrintInfo();
            truck.startEngine();
            truck.Load(2000);

            minibus.PrintInfo();
            minibus.startEngine();
            minibus.Refuel();

            coupe.PrintInfo();
            coupe.startEngine();

            Console.ReadKey();
        }
    }
}
