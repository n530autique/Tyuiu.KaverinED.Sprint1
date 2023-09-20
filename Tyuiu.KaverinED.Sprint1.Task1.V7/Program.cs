﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KaverinED.Sprint1.Task1.V7.Lib;
namespace Tyuiu.KaverinED.Sprint1.Task1.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Каверин Е. Д. | ИИПб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Каверин Егор Дмитриевич | ИИПб-23-3                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле (5*x)/(y+x) и печатает его на экране.    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"* РЕЗУЛЬТАТ: {ds.Calculate(x, y)}                                                            *");
            Console.WriteLine("***************************************************************************");
            Console.ReadLine();
        }
    }
}

