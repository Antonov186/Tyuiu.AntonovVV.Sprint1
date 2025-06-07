using Tyuiu.AntonovVV.Sprint1.Task4.V20.Lib;
namespace Tyuiu.AntonovVV.Sprint1.Task4.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Антонов В.В. | ИСПб-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #1                                                             *");
            Console.WriteLine("* Тема: Class Math                                                      *");
            Console.WriteLine("* Задание #4                                                            *");
            Console.WriteLine("* Варинат #20                                                           *");
            Console.WriteLine("* Выполнил: Антонов В. В. | ИСПб-24-1                                   *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                              *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные       *");
            Console.WriteLine("* данные, вычисляет результат по формуле и печатает его на экране.      *");
            Console.WriteLine("*                                                                       *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("*************************************************************************");

            int x, y;
            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение Y:");
            y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                            *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine("(1+x)/abs(x-sqrt(2+y)) = " + ds.Calculate(x, y));
            Console.ReadKey();
        }
    }