using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("qual a altura");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("qual a base");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("A área do retangulo é " + a * b);
        }
    }
}
