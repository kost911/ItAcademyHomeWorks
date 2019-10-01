using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Int32 a1 = 1;
            Console.WriteLine(a.GetType());
            Console.WriteLine(a1.GetType());
            Console.WriteLine("--------------");
            byte b = 2;
            Byte b1 = 2;
            Console.WriteLine(b.GetType());
            Console.WriteLine(b1.GetType());
            Console.WriteLine("--------------");
            char c = 'G';
            Char c1 = 'G';
            Console.WriteLine(c.GetType());
            Console.WriteLine(c1.GetType());
            Console.WriteLine("--------------");
            ulong d = 18446744073709551615;
            UInt64 d1 = 18446744073709551615;
            Console.WriteLine(d.GetType());
            Console.WriteLine(d1.GetType());
            Console.WriteLine("--------------");
            uint i = 4294967295;
            UInt32 i1 = 4294967295;
            Console.WriteLine(i.GetType());
            Console.WriteLine(i1.GetType());
            Console.WriteLine("--------------");
            string f = "Str";
            String f1 = "Str";
            Console.WriteLine(f.GetType());
            Console.WriteLine(i1.GetType());
            Console.WriteLine("--------------");
            object g = "Str";
            Object g1 = "Str";
            Console.WriteLine(g.GetType());
            Console.WriteLine(g1.GetType());
            Console.WriteLine("--------------");
            Console.ReadKey();
        }
    }
}
