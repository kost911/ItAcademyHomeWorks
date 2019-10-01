using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int fnum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second number");
            int snum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(fnum+snum);
            Console.ReadKey();
        }
    }
}
