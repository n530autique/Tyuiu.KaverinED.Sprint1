using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaverinED.Sprint1.Task6.V7.Lib;
namespace Tyuiu.KaverinED.Sprint1.Task6.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Каверин Е. Д. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Каверин Егор Дмитриевич | ИИПб-23-3                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
            Console.WriteLine("* Пусть k – целое от 1 до 365. Присвоить целой переменной n значение 1,2,...,7 *");
            Console.WriteLine("* в зависимости от того, на какой день недели приходится k-й день         *");
            Console.WriteLine("* невисокосного года, в котором 1 января – понедельник.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите предложение: ");
            string a = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"* РЕЗУЛЬТАТ: {ds.DeleteLastLetter(a)}                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.ReadLine();
        }
    }
}
