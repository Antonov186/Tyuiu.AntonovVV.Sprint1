using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AntonovVV.Sprint1.Task1.V13.Lib
{
    public class DataService : ISprint1Task1V13
    {
        public double Calculate(double x)
        {
            return x / (0.5 * x);
        }
    }
}
