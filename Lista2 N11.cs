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
            /*Escreva um programa, usando o comando SWITCH, que leia uma letra e informe se a letra é uma vogal
ou consoante. Considere que o usuário sempre irá informar uma letra. (Dica: não será necessário informar
diretamente no código todas as 26 letras. Pense em uma forma mais inteligente de fazer esse
processamento).*/
            char letra;
            Console.WriteLine("Digite uma letra do alfabeto");
            letra = char.Parse(Console.ReadLine());
            switch(char.ToLower(letra))
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
