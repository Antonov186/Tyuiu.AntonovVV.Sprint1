using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AntonovVV.Sprint1.Task3.V7.Lib
{
    public class DataService : ISprint1Task3V7
    {
        public double VerstsToKilometers(double verst)
        {
            return verst * 1066.8 / 1000;
        }
    }
}