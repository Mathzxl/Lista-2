using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N8
{
    internal class Program
    {
        static void Main(string[] args)
        { /*Usando o comando switch, escreva um programa que leia um número inteiro entre 1 e 7 e imprima o
dia da semana correspondente ao número. Considere a semana iniciando no domingo (1). Caso o usuário
digite um valor menor que 1 ou maior que 7, seu programa deve exibir a mensagem: “Dia inválido”.*/
            int dia;
            Console.WriteLine("Digite um numero de 1 a 7");
            dia = int.Parse(Console.ReadLine());
            switch(dia)
            {
                case 1:
                    Console.WriteLine("Hoje é domingo");
                    break;
                case 2:
                    Console.WriteLine("Hoje é segunda");
                    break;
                case 3:
                    Console.WriteLine("Hoje é terça");
                    break;
                case 4:
                    Console.WriteLine("Hoje é quarta");
                    break;
                case 5:
                    Console.WriteLine("Hoje é quinta");
                    break;
                case 6:
                    Console.WriteLine("Hoje é sexta");
                    break;
                case 7:
                    Console.WriteLine("Hoje é sabado");
                    break;
                default:
                    Console.WriteLine("Numero Invalido");
                    break;
            }
            Console.ReadLine();
        }
    }
}
