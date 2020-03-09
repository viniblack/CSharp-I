using System;

namespace P11___CalculaPopanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");

            double valorIvestido = 1000;


            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {

                valorIvestido *= 1.0036;
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$" + valorIvestido);

            }



            Console.ReadLine();
        }
    }
}
