using System;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quatidadePessoas = 1;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade, pode entrar.");
            }
            else
            {
                if (quatidadePessoas >= 2)
                {
                    Console.WriteLine("João possui menos de 18 anos, mas esta acompanhado");
                }
                else
                {
                    Console.WriteLine("João possui menos de 18 anos de idade e não esta acompanhado , não pode entrar.");
                }
            }

            Console.ReadLine();
        }
    }
}
