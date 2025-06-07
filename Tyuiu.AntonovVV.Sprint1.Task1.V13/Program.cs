using Tyuiu.AntonovVV.Sprint1.Task1.V13.Lib;
namespace Tyuiu.AntonovVV.Sprint1.Task1.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Sprint #1 | Выполнила: Антонов В. В. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Sprint #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("*  Выполнила: Антонов В. В. | ИСПб-24-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле x / ( 0.5 * x ) и печатает его на экране.*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* x / (0.5 * x)                                                           *");
            Console.WriteLine("***************************************************************************");

            double x;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x));

            Console.ReadLine();

        }
    }
}