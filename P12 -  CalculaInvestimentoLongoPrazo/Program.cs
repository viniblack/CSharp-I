using System;

namespace P12____CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12");

            double valorInvestido = 1000;
            double fatorRedimento = 1.0036;

            for(int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes < 12; contadorMes++)
                {
                    valorInvestido *= fatorRedimento;
                }
                fatorRedimento += 0.0010;
            }

            Console.Write("Ao término do investimento, você terá R$" + valorInvestido);

            Console.ReadLine();
        }
    }
}
