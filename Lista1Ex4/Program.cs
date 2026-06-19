using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b;
            double a;

            Console.WriteLine("Digite o valor da base do triângulo: ");
            b = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o valor da altura do triângulo: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("A área do triângulo é: ", (b * a) / 2);
        }
    }
}
