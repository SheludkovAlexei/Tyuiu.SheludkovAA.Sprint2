using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SheludkovAA.Sprint2.Task2.V8.Lib;

namespace Tyuiu.SheludkovAA.Sprint2.Task2.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            

            Console.Title = "Спринт #2 | Выполнил: Шелудков А. А. | АСОиУб-23-1 ";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Шелудков А. А. | АСОиУб-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает значения с клавиатуры и         *");
            Console.WriteLine("* вычисляет находится ли  точка с координатами X Y в области              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Координата X = " + x);
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Координата Y = " + y);
            bool res = ds.CheckDotInShadedArea(x, y);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (res)
                Console.WriteLine("Точка находится в заштрихованной области");
            else
                Console.WriteLine("Точка не находится в заштрихованной области");
            Console.ReadKey();
        }
    }
}
