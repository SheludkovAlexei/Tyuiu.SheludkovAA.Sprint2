using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SheludkovAA.Sprint2.Task5.V9.Lib;

namespace Tyuiu.SheludkovAA.Sprint2.Task5.V9
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Шелудков А. А. | АСОиУб-23-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите порядковый номер месяца");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            if ((m>12)||(n>31))
            {
                Console.WriteLine("Введены неправильные данные");
            }
            else
            {
                if ((m == 2) && (n > 28))
                {
                    Console.WriteLine("Такого дня не существует");
                }
                else if ((m == 4) && (n > 30))
                {
                    Console.WriteLine("Такого дня не существует");
                }
                else if ((m == 6) && (n > 30))
                {
                    Console.WriteLine("Такого дня не существует");
                }
                else if ((m == 9) && (n > 30))
                {
                    Console.WriteLine("Такого дня не существует");
                }
                else if ((m == 11) && (n > 30))
                {
                    Console.WriteLine("Такого дня не существует");
                }
                else
                {
                    Console.WriteLine("***************************************************************************");
                    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                    Console.WriteLine("***************************************************************************");
                    Console.WriteLine("На следующий день будет " + ds.FindDateOfNextDay(m, n));
                    
                }
            }
            Console.ReadKey();



        }
    }
}
