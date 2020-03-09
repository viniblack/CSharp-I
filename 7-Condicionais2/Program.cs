using System;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais 2");

            int idadeJoao = 16;
            int quatidadePessoas = 2;
            bool acompanhado = quatidadePessoas >= 2;

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }

            Console.ReadLine();
        }
    }
}
