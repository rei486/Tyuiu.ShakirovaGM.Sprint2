using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShakirovaGM.Sprint2.Task1.V27.Lib
{
    public class DataService : ISprint2Task1V27
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (a<b)|(c>d);
            res[1] = (a==b)&(c==d);
            res[2] = (b < d)|| (a == c + 500);
            res[3] = (b > d) && (a == c + 500);
            res[4] = !(res[3]);
            res[5] = (a == b) ^ (c == d);
            return res;
        }
    }
}
//a = 654, b = 325, c = 154, d = 333
//(False, False, True, False, True, False)