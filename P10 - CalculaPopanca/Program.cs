using System;

namespace P10___CalculaPopanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 10 - Calcula poupança");

            double valorIvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorIvestido = valorIvestido + valorIvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorIvestido);
                contadorMes++;
            }

            Console.WriteLine();
        }
    }
}
