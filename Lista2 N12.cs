using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N12
{
    internal class Program
    {
        static void Main(string[] args)
        { /*Faça um programa que leia a altura e o sexo de uma pessoa (F ou M), calcule e mostre o seu peso ideal,
utilizando as seguintes fórmulas:
• Para homens: (72,7 * h) – 58
• Para mulheres: (62,1 * h) – 44,7
(h é a altura)*/
            double h, pesoIdeal;
            char sexo;
            Console.WriteLine("Digite a altura de uma pessoa qualquer");
            h = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o sexo de uma Pessoa (F) Feminino (M) Masculino");
            sexo = char.Parse(Console.ReadLine());
            pesoIdeal = sexo == 'M' ? (72.7 * h) - 58 : (62.1 * h) - 44.7;
            Console.WriteLine("O peso ideal para um " + genero + " com " + h + " metros de altura é: " + pesoIdeal + "kg");
            Console.ReadLine();
        }
    }
}
