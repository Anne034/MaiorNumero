using System;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
            //Programa básico q lê 3 números e mostra o maior entre eles ^u^
        {
            Console.WriteLine("Digite três números inteiros: ");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("Maior =" + n1);

            }

            else if (n2 > n3) 
            {
                Console.WriteLine("Maior =" + n2);
            }
            else
            {
                Console.WriteLine("Maior =" + n3);
            }

        }
    }
}