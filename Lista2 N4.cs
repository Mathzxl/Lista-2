using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escreva um programa para mostrar o menu de opções abaixo. Na sequência, leia a opção do usuário e
os dados necessários para executar cada operação. Calcule a operação selecionada pelo usuário e imprima
na tela o resultado.
Menu de Opções
1. Somar dois números.
2. Subtrair dois números.
3. Multiplicação de dois números.
4. Divisão de dois números.
Obs.: Verifique se a divisão é por 0 (zero). Caso seja, imprima “Erro”.*/
            int menu;
            double n1, n2;
            Console.WriteLine("Escolha a operação:\n1. + (Adição)\n2. - (subtração)\n3. * (Multiplicação)\n4. / (Divisão)");
            menu = int.Parse(Console.ReadLine());
            Console.WriteLine("De um numero qualquer");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("De o valor de outro numero");
            n2 = double.Parse(Console.ReadLine());
            if (menu == 1)
            {
                Console.WriteLine("Resultado: " + (n1 + n2));
            }
            else if (menu == 2)
            {
                Console.WriteLine("Resultado: " + (n1 - n2));
            }
            else if (menu == 3)
            {
                Console.WriteLine("Resultado: " + (n1 * n2));
            }
            else if (menu == 4)
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Erro");
                }
                else
                {
                    Console.WriteLine("Resultado: " + (n1 / n2));
                }
            }
            else
            {
                Console.WriteLine("Operação inválida");
            }
            Console.ReadLine();
        }
    }
}
