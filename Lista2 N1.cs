using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_N1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que leia 3 idades. Imprima a menor e a maior idade
            int id1, id2, id3;
            Console.WriteLine("Digite A idade de uma primeira pessoa qualquer");
            id1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade de uma segunda pessoa qualquer");
            id2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade de uma terceira pessoa");
            id3 = int.Parse(Console.ReadLine());
            if (id1 < id2)
            {
                if (id2 < id3)
                {
                    Console.WriteLine("O menor é " + id1 + " e o maior é " + id3);
                }
                else if (id3 < id1)
                {
                    Console.WriteLine("O menor é " + id3 + " e o maior é " + id2);
                }
                else
                {
                    Console.WriteLine("O menor é " + id1 + " e o maior é " + id2);
                }
            }
            else if (id2 < id3)
            {
                if (id1 < id3)
                {
                    Console.WriteLine("O menor é " + id2 + " e o maior é " + id3);
                }
                else
                {
                    Console.WriteLine("O menor é " + id2 + " e o maior é " + id1);
                }

            }
            else
            {
                Console.WriteLine("O menor é " + id3 + " e o maior é " + id1);
            }
            Console.ReadLine();
        }
    }
}
