using Models4.Interfaces;

namespace Models4
{
    public class Truck : Vehicle, ICarWash
    {
        public int Size { get; set; }

        public Truck(string model, string serialNumber, int size): 
            base(model, serialNumber)
        {
            Size = size;
        }
        public override string Drive()
        {
            return $"Truck {Model} size is {Size}";
        }

        public string WashCar()
        {
            throw new NotImplementedException();
        }
        public string WashTrailer()
        {
            return $"This truck {Model} is washed";
        }
    }
}
