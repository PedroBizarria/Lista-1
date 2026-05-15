using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Diagonal;
            double area;

            Console.WriteLine("informe a diagonal do quadrado: ");
            Diagonal = double.Parse(Console.ReadLine());

            area = (Diagonal * Diagonal) / 2;
            
            Console.WriteLine("A area do quadrado é: ");
            Console.WriteLine(area);
        }
    }
}
