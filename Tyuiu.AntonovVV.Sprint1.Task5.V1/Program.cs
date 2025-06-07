using Tyuiu.AntonovVV.Sprint1.Task5.V1.Lib;
namespace Tyuiu.AntonovVV.Sprint1.Task5.V1
{
    
        class Program
        {
            static void Main(string[] args)
            {
                DataService ds = new DataService();

                Console.Title = "Спринт#1 | Выполнил: Антонов В. В. | ИСПб-24-1";
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* Спринт #1                                                               *");
                Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
                Console.WriteLine("* Задание #5                                                              *");
                Console.WriteLine("* Вариант #1                                                              *");
                Console.WriteLine("* Выполнил: Антонов В. В. | ИСПб-24-1                                     *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* УСЛОВИЕ:                                                                *");
                Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
                Console.WriteLine("* Ответ привести к целому с помощью класса Convert.                       *");
                Console.WriteLine("*                                                                         *");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
                Console.WriteLine("***************************************************************************");

                Console.WriteLine("Введите координату x1: ");
                double x1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату y1: ");
                double y1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату x2: ");
                double x2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите координату y2: ");
                double y2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

                Console.WriteLine(ds.DistanceBetweenDots(x1, y1, x2, y2));
                Console.ReadKey();
            }
        }
    }