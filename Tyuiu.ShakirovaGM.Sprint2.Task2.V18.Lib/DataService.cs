using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShakirovaGM.Sprint2.Task2.V18.Lib
{
    public class DataService : ISprint2Task2V18
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (((y>=3)&&(y<=5)&& (x >= 3) && (x <= 7))|| ((y >= 6) && (y <= 8) && (x >= 5) && (x <= 9)) || ((y == 2) && (x >= 6) && (x <= 7)) || ((y == 12) && (x >= 3) && (x <= 5)) || ((y >= 12) && (y <= 13) && (x >= 6) && (x <= 8)) || ((y >= 11) && (y <= 12) && (x >= 8) && (x <= 11)) || ((y >= 9) && (y <= 10) && (x >= 8) && (x <= 9)) || ((y >= 6) && (y <= 7) && (x >= 10) && (x <= 11)) || ((y >= 3) && (y <= 5) && (x == 11)) || ((y == 7) && (x == 12)) )
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
