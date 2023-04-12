using Models4.Interfaces;

namespace Models4
{
    public class RepairService : IRepairService
    {
       public string CheckVehicle()
        {
            return "Vehicle is Broken";
        }
        public string FixVehicle()
        {
            return "Vehicle is repaired";
        }
    }
}
