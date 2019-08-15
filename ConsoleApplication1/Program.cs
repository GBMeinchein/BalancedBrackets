using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (1 == 1)
            {
                Console.WriteLine("Digite uma sequencia de brackets: ");
                var caracteres = Console.ReadLine();
                bool valido = BalancedBrackets.IsBalancedBrackets(caracteres);

                Console.WriteLine("A sequência de brackets " + (valido ? "é" : "não é") + " válido");
            }
        }
    }
}
