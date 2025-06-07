using Tyuiu.AntonovVV.Sprint1.Task3.V7.Lib;
namespace Tyuiu.AntonovVV.Sprint1.Task3.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine("Введите расстояние в верстах и нажмите <Enter>");



            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");




            double verst = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Расстояние в вёрстах равен: " + ds.VerstsToKilometers(verst));
            Console.ReadLine();

        }
    }
}