using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N11
{
    internal class Program
    {
        static void Main(string[] args)
        {
           char letra;
            Console.WriteLine("Digite uma letra do alfabeto");
            letra = char.Parse(Console.ReadLine());
            int n = (int)letra;
            if(n >= 65 && n <= 90)
            {
                letra = (char)(letra + 32);
            }
            switch (letra)
            {
                case 'a':
                    Console.WriteLine("A letra é uma vogal");
                    break;
                case 'e':
                    Console.WriteLine("A letra é uma vogal");
                    break;
                case 'i':
                    Console.WriteLine("A letra é uma vogal");
                    break;
                case 'o':
                    Console.WriteLine("A letra é uma vogal");
                    break;
                case 'u':
                    Console.WriteLine("A letra é uma vogal");
                    break;
                default:
                    Console.WriteLine("A letra é uma consoante");
                    break;
            }
            Console.ReadLine();
        }
    }
}
