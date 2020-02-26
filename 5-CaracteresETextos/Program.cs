using System;


    namespace _5_CaracteresETextos
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

                char primeiraLetra = 'a';
                Console.WriteLine(primeiraLetra);

                primeiraLetra = (char)61;
                Console.WriteLine(primeiraLetra);

                primeiraLetra = (char)(primeiraLetra + 1);
                Console.WriteLine(primeiraLetra);

                string titulo = "Alura Cursos de tecnologia";
                Console.WriteLine(titulo);

                Console.ReadLine();
            }
        }
    }

        
