using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado;
            double area;

            Console.WriteLine("informe o lado do quadrado: ");
            lado = double.Parse(Console.ReadLine());
            area = lado * lado;

            Console.WriteLine("A área do quadrado é: ");
            Console.WriteLine(area);
        }
    }
}
