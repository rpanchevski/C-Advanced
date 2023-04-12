using Models4.Interfaces;

namespace Models4
{
    public class GasPump : IGasPump
    {
       public string PumpGas()
        {
           return "Gas is full..";
        }
    }
}
