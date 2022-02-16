using System;

namespace DiamanteLetras
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string letra;
            int linhas;
            string letras = "abcdefghijklmnopqrstuvwxyz";
            Console.WriteLine("Escreva uma letra minúscula");
            letra = Console.ReadLine();
            linhas = letras.IndexOf(letra);
            int espaçosLinhas = linhas;
            int somaEspaços = 0;

            for (int i = 0; i < linhas; i++)
            {
                for (int k = 0; k < espaçosLinhas; k++)
                {
                    Console.Write(" ");
                }
                Console.Write(letras[i]);
                for (int l = 0; l < somaEspaços; l++)
                {
                    Console.Write(" ");
                }
                if (i >= 1)
                {
                    Console.Write(letras[i]);
                }
                somaEspaços += 2;
                espaçosLinhas--;
                Console.WriteLine();
            }
            for (int i = linhas; i >=0; i--)
            {
                for (int k = 0; k < espaçosLinhas; k++)
                {
                    Console.Write(" ");
                }
                Console.Write(letras[i]);
                for (int l = 0; l < somaEspaços; l++)
                {
                    Console.Write(" ");
                }
                if (i>=1 && i <= linhas)
                {
                    Console.Write(letras[i]);
                }                                        
                somaEspaços -= 2;
                espaçosLinhas++;
                Console.WriteLine();
            }
        }
    }
}
