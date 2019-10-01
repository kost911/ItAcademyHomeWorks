using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw3_T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("operation + or -");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "+":

                    Console.WriteLine("enter result");
                    int sum = Convert.ToInt32(Console.ReadLine());

                    if (sum == num1 + num2)
                    {
                        Console.WriteLine(sum + " this is the correct answer");
                    }
                    else if (sum < num1 + num2)
                    {
                        Console.WriteLine("the answer is incorrect, should be more");
                    }
                    else if (sum > num1 + num2)
                    {
                        Console.WriteLine("the answer is incorrect, should be less");
                    }
                    break;

                case "-":

                    Console.WriteLine("enter result");
                    int difference = Convert.ToInt32(Console.ReadLine());

                    if (difference == num1 - num2)
                    {
                        Console.WriteLine(difference + " this is the correct answer");
                    }
                    else if (difference < num1 - num2)
                    {
                        Console.WriteLine("the answer is incorrect, should be more");
                    }
                    else if (difference > num1 - num2)
                    {
                        Console.WriteLine("the answer is incorrect, should be less");
                    }
                    break;
                default:
                    Console.WriteLine("invalid operator selected");
                    break;
            }
                Console.ReadKey();
        }
    }
}
