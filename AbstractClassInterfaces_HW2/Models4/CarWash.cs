using Models4.Interfaces;

namespace Models4
{
    public class CarWash : ICarWash
    {
        public string WashCar()
        {
            return "This car is clean.";
        }
        public string WashTrailer()
        {
            return "This trailer is clean";
        }
    }
}
