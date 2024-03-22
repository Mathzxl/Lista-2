using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idn;
            Console.WriteLine("De a Idade de uma nadador");
            idn = int.Parse(Console.ReadLine());
            if (idn >= 5 && idn <= 7)
            {
                Console.WriteLine("Classificação: Infantil A");
            }
            else if (idn >= 8 && idn <= 10)
            {
                Console.WriteLine("Classificação: Infantil B");
            }
            else if (idn >= 11 &&  idn <= 13)
            {
                Console.WriteLine("Classificação: Juvenil A");
            }
            else if (idn >= 14 && idn <= 17)
            {
                Console.WriteLine("Classificação: Juvenil B");
            }
            else if (idn >= 18)
            {
                Console.WriteLine("Classificação: Sênior");
            }
            else
            {
                Console.WriteLine("O nadador não tem idade para entrar em uma classificação");
            }
            Console.ReadLine();
        }
    }
}
