using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa que leia a idade de uma pessoa, o tipo de habilitação que ela possui e o tempo
que ela possui carteira de habilitação. Verifique e informe se a pessoa possui os requisitos necessários para
tirar uma carteira de habilitação do tipo D. Caso ela não possua os requisitos, indique em uma mensagem
o motivo pelo qual ela não possui permissão.
Requisitos carteira habilitação tipo D:
1. Ter 21 anos completos;
2. Estar habilitado no mínimo há 2 anos na categoria B ou 1 ano na categoria C.*/
            int idp, tch;
            char th;
            Console.WriteLine("Digite a Idade de uma pessoa qualquer");
            idp = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tipo de habilitação dessa mesma pessoa");
            th = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tempo de carteira da mesma pessoa");
            tch = int.Parse(Console.ReadLine());
            if (idp >= 21)
            {
                if (th == 'b' || th == 'B')
                {
                    if (tch >= 2)
                    {
                        Console.WriteLine("Pode tirar a carteira tipo D!");
                    }
                    else
                    {
                        Console.WriteLine("Não pode tirar a carteira tipo D");
                    }
                }
                else if (th == 'c' || th == 'C')
                {
                    if (tch >= 1)
                    {
                        Console.WriteLine("Pode tirar a carteira tipo D!");
                    }
                    else
                    {
                        Console.WriteLine("Não pode tirar a carteira tipo D");
                    }
                }
                else
                {
                    Console.WriteLine("Não pode tirar a carteira tipo D");
                }
            }
            else
            {
                Console.WriteLine("Não pode tirar a carteira tipo D");
            }
            Console.ReadLine();
        }
    }
}
