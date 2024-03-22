using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa que leia um número e informe se ele é divisível por 3 e também por 5 (Exemplo: 15
é divisível por 3 e por 5)*/
            int n;
            Console.WriteLine("De o valor qualquer de um numero inteiro");
            n = int.Parse(Console.ReadLine());
            if (n % 3 == 0 && n % 5 == 0)
            {
                Console.WriteLine("O numero é divisivel por 3 e por 5");
            }
            else
            {
                Console.WriteLine("O numero não é divisivel por 3 e por 5");
            }
            Console.ReadLine();
        }
    }
}
