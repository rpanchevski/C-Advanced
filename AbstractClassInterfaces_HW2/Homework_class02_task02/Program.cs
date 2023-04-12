using Models4;

namespace Homework_class02_task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("Peugeot", "AB273072", true);
            Car c2 = new Car("BMW", "MM123456", false);

            Truck t1 = new Truck("Van", "CC654789", 20);
            Truck t2 = new Truck("Tanker", "TT789654", 50);

            Console.WriteLine(c1.Drive());
            Console.WriteLine(c1.WashCar());
            //Console.WriteLine(c1.WashTrailer());
            Console.WriteLine(c2.Drive());
            Console.WriteLine(c2.WashCar());

            Console.WriteLine(t1.Drive());
            //Console.WriteLine(t1.WashCar());
            Console.WriteLine(t1.WashTrailer());
            Console.WriteLine(t2.Drive());
            Console.WriteLine(t2.WashTrailer());

            CarWash cw = new CarWash();
            GasPump gp = new GasPump();
            RepairService rs = new RepairService();

            Console.WriteLine(cw.WashCar());
            Console.WriteLine(cw.WashTrailer());

            Console.WriteLine(gp.PumpGas());

            Console.WriteLine(rs.CheckVehicle());
            Console.WriteLine(rs.FixVehicle());
        }
    }
}