using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itAcademyWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-й пример явного преобразования;
            int z = 3;
            int r = 5;
            byte v = (byte) (z + r);
            //2-й пример явного преобразования;
            double o = 3.14;
            int i = (int)o;
            //3-й пример явного преобразования;
            ulong u = 123123123123;
            decimal g = (ulong)u;

            //1-й пример неявного преобразования;
            byte a = 127;
            short b = (byte)(a + a);
            //2-й пример неявного преобразования;
            int x = 12;
            int y = 7;
            double n = x / y;
            //2-й пример неявного преобразования;
            object p = 33.4;
            double t = Convert.ToDouble(p);

            //операция упаковки;
            int m = 333;
            object e = m;
            //операция распоковки;
            int l = (int)e;
        }
    }
}
