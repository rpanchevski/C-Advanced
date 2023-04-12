
using Models4.Interfaces;

namespace Models4
{
    internal class CarCenter : ICarWash, IGasPump, IRepairService 
    {
        public string WashCar()
        {
            return "Checking if this car is clean..";
        }
        public string WashTrailer()
        {
            return "Checking if this trailer is clean...";
        }
        public string PumpGas()
        {
            return "Checking if Gas is full..";
        }
        public string CheckVehicle()
        {
            return "Checking if Vehicle is Broken";
        }
        public string FixVehicle()
        {
            return "Vehicle which  was broken is repaired";
        }
    }
}
