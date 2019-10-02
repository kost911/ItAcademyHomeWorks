using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw4_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("select the direction of movement W A S D");
            string direction = Convert.ToString(Console.ReadLine());
            switch (direction)
            {
                case "W":
                    Console.WriteLine("upward movement selected");
                    break;
                case "A":
                    Console.WriteLine("left movement selected");
                    break;
                case "S":
                    Console.WriteLine("right movement selected");
                    break;
                case "D":
                    Console.WriteLine("downward movement selected");
                    break;
                default:
                    Console.WriteLine("error in direction selection");
                    break;
            }
            Console.ReadKey();
        }
    }
}
