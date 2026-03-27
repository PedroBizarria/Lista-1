using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjExemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(74);
            Console.WriteLine(7.4);
            Console.WriteLine("IFSP");
            Console.WriteLine('*');

            int timmaia;
            int robertocarlos;
            int beatles;
            Console.Write("Digite o primeiro numero:");
            timmaia = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo nuemero:");
            robertocarlos = int.Parse(Console.ReadLine());

            beatles = timmaia + robertocarlos;

            Console.Write("Resultado da soma:");
            Console.WriteLine(beatles);

            Console.Write("Resultado da soma {0} com {1} é {2}", timmaia, robertocarlos, beatles);
        }
    }
}
