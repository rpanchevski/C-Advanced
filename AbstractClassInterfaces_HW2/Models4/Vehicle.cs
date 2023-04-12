using Models4.Interfaces;
namespace Models4
{
    public abstract class Vehicle : IGasPump, IRepairService 
    {
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public abstract string Drive();

        public Vehicle(string model, string serialNumber)
        {
            Model = model;
            SerialNumber = serialNumber;
        }
        public string PumpGas()
        {
            return $"{Model} gas..";
        }
        public string CheckVehicle()
        {
            return $"{Model} reparation needed?";
        }
        public string FixVehicle()
        {
            return $"{Model} fixed.";
        }

    }
}