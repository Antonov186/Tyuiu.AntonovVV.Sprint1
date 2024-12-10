using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AntonovVV.Sprint1.Task1.V13.Lib;


namespace Tyuiu.AntonovVV.Sprint1.Task1.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Антонов В.В. | ИСПБ-24-1";
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание 1                                                               *");
            Console.WriteLine("* Вариант 13                                                              *");
            Console.WriteLine("* Выполнил: Антонов Василий Викторович | ИСПБ-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *"); 
            Console.WriteLine("* вычисляет результат по формуле x / (0.5 * x) и печатает его на экране.  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x;

            Console.WriteLine("Введите значение x");
            x = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(x));

            Console.ReadLine();
        }
    }
}
