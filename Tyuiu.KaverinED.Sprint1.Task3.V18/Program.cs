using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaverinED.Sprint1.Task3.V18.Lib;
namespace Tyuiu.KaverinED.Sprint1.Task3.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Каверин Е. Д. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #18                                                              *");
            Console.WriteLine("* Выполнил: Каверин Егор Дмитриевич | ИИПб-23-3                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет, сколько квадратов со стороной С  *");
            Console.WriteLine("* можно разместить внутри прямоугольника с размерами A x B без наложений. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите длину прямоуголника: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину прямоугольника: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите длину квадрата: ");
            z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"* РЕЗУЛЬТАТ: {ds.HowManySquares(x, y, z)}                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.ReadLine();
        }
    }
}
