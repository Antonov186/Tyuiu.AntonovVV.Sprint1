using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

//Важно! Следует к библиотеке классов подключить файл tyuiu.cources.programming.interfaces.dll
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AntonovVV.Sprint1.Task0.V29.Lib
{
    public class DataService : ISprint1Task0V29
    {
        public double Calculate()
        {
            return 2 * 9 + 7 * 2;
        }
    }
}