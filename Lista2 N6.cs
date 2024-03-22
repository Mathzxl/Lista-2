using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Escolha uma das Seguintes Medidas:\n\n(1) Geometrica\n\n(2) Ponderada\n\n(3) Harmonica\n\n(4) Aritmetica\n\n");
            int w = int.Parse(Console.ReadLine());
           Console.WriteLine("De o valor de 3 numero inteiros positivo");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            double res;
           
            if (w == 1)
            {
                res = Math.Sqrt(x * y * z);
                Console.WriteLine("O valor da Geometrica = " + res);
            }
            else if (w == 2)
            {
                res = (x + 2 * y + 3 * z) / 6;
                Console.WriteLine("O valor da Ponderada = " + res);
            }
            else if (w == 3)
            {
                res = 1 / ((1 / x) + (1 / y) + (1 / z));
                Console.WriteLine("O valor da Harmonica = " + res);
            }
            else if (w == 4)
            {
                res = (x + y + z) / 3;
                Console.WriteLine("O valor da Aritimetica = " + res);
            }
            else
            {
                Console.WriteLine("O valor informado é invalido");
            }
            Console.ReadLine();
        }
    }
}
