using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SheludkovAA.Sprint2.Task2.V8.Lib
{
    public class DataService : ISprint2Task2V8
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if ((x >= 9 && x <= 11 && y == 2) || (x >= 3 && x <= 5 && y == 3) || (x >= 9 && x <= 12 && y == 3) || (x >= 3 && x <= 5 && y == 4) || (x >= 9 && x <= 11 && y == 4) || (x >= 3 && x <= 9 && y == 5) || (x >= 3 && x <= 13 && y == 6) || (x >= 3 && x <= 6 && y == 7) || (x >= 9 && x <= 14 && y == 7) || (x == 6 || x == 9 && y == 8) || (x >= 12 && x <= 13 && y == 8) || (x >= 6 && x <= 9 && y == 9) || (x >= 12 && x <= 13 && y == 9) || (x >= 6 && x <= 9 && y == 10)||(x>=3 && x<=9 && y==11) || (x>=7&& x<=9 && y == 12))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
