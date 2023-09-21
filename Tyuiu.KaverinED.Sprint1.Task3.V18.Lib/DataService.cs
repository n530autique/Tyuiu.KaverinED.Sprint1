using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KaverinED.Sprint1.Task3.V18.Lib
{
    public class DataService : ISprint1Task3V18
    {
        public double HowManySquares(double a, double b, double c)
        {
            int x = Convert.ToInt32(Math.Floor(a / c)), y = Convert.ToInt32(Math.Floor(b / c));
            return x * y;
        }
    }
}
