using Models4.Interfaces;

namespace Models4
{
    public class Car : Vehicle, ICarWash
    {
        public bool IsElectric;
        public Car(string model, string serialNumber, bool isEletric) :
            base(model, serialNumber)
        {
            IsElectric = isEletric;
        }

        public override string Drive()
        {
            return $"Is this car{Model} electric? - {IsElectric}";
        }

        public string WashCar()
        {
            return $"This car {Model} with Serial number {SerialNumber} is washed";
        }
        public string WashTrailer()
        {
            throw new NotImplementedException();
        }
    }
    
}
