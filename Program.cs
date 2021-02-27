using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TestaPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaPrimo valor = new TestaPrimo();
            Stopwatch sw = new Stopwatch();

            int n = 2147483647; // Para grandes numeros recomendo diminuir o numero e rodar abaixo
            int rodar = 10;
            int primo = valor.Primo(n);
            int[] vetor;
            vetor = new int[rodar];

            if (primo == 1)
                Console.WriteLine("Eh Primo");
            else
                Console.WriteLine("Nao eh Primo");

            for(int i=0; i<rodar; i++)
            {
                sw.Start();
                valor.Primo(n);
                sw.Stop();
                vetor[i] = (int)sw.Elapsed.TotalMilliseconds;
                Console.WriteLine($"Tempo {i+1}: {sw.Elapsed.TotalMilliseconds} ms");
            }
            float media = 0;
            float soma = 0;
            for(int j=0; j<rodar; j++)
            {
                soma += vetor[j];
            }
            media = soma / rodar;

            float somaDoDesvio = 0;
            float diff = 0;
            for(int k=0; k<rodar; k++)
            {
                diff = vetor[k] - media;
                somaDoDesvio += (float)Math.Pow(diff, 2);
            }
            float desvioPadrao = (float)Math.Sqrt(somaDoDesvio / rodar);
            

            Console.WriteLine($"Tempo medio passado: {media} ms");
            Console.WriteLine($"Desvio padrao: {desvioPadrao}");
        }
    }
}
