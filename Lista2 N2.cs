using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia um número entre 0 e 5 e imprima o valor lido por extenso(ex: “Cinco”),
se o número estiver fora dessa faixa imprima “Valor inválido”*/
            int numero;
            Console.WriteLine("Digite um numero de 0 a 5");
            numero = int.Parse(Console.ReadLine());
            if (numero >= 0 && numero <= 5)
            {
                if(numero == 0)
                {
                    Console.WriteLine("O numero iformado é o numero zero");
                }
                else if (numero == 1)
                {
                    Console.WriteLine("O numero informado é o numero um");
                }
                else if (numero == 2)
                {
                    Console.WriteLine("O numero informado é o numero dois");
                }
                else if (numero == 3)
                {
                    Console.WriteLine("O numero informado é o numero três");
                }
                else if (numero == 4)
                {
                    Console.WriteLine("O numero informado é o numero quatro");
                }
                else
                {
                    Console.WriteLine("o numero informado é o numero cinco");
                }
            }
            else
            {
                Console.WriteLine("O numero informado é menor que 0 ou maior que 5");
            }
            Console.ReadLine();
        }
    }
}
