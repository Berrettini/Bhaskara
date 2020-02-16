using System;

namespace bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, x1, x2;
            Console.WriteLine("Programa para calcular Bhaskara!");
            Console.Write("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            c = double.Parse(Console.ReadLine());

            d = (Math.Pow(b, 2) - (4 * a * c));
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);

            Console.WriteLine();
            Console.WriteLine("O valor de delta é: " + d);
            Console.WriteLine();
            Console.WriteLine("O valor de x1 é: " + x1);
            Console.WriteLine();
            Console.WriteLine("O valor de x2 é: " + x2);
            Console.WriteLine();
            Console.WriteLine("Tecle ENTER para sair!");
            Console.ReadLine();

        }
    }
}
