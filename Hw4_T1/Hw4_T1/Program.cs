using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4_T1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = (char)90 ; i >= (char)65; i--)
            {
                Console.WriteLine(Convert.ToChar(i));
            }
            Console.ReadKey();
        }      
    }
}
