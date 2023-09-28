using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KaverinED.Sprint1.Task7.V11.Lib
{
    public class DataService : ISprint1Task7V11
    {
        public double Calculate(double x, double y)
        {
            double a, b, c;
            a = Math.Pow(Math.Log(Math.Sin(x), Math.Exp(1)), x);
            b = Math.Log(1 + x * x, Math.Exp(1));
            c = y - Math.Sqrt(Math.Abs(x));
            double res = Math.Round(a / b + c, 3);
            return res;
        }
    }
}
