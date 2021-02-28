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
            var sw = new Stopwatch();

            int n = 7; // Para grandes numeros recomendo diminuir o numero e rodar abaixo
            int rodar = 10;
            int primo = valor.Primo(n);
            long[] vetor;
            vetor = new long[rodar];

            if (primo == 1)
                Console.WriteLine("Eh Primo");
            else
                Console.WriteLine("Nao eh Primo");

            for(int i=0; i<rodar; i++)
            {
                sw.Start();
                valor.Primo(n);
                sw.Stop();
                vetor[i] = (long)sw.Elapsed.Ticks;
                Console.WriteLine($"Tempo {i+1}: {sw.Elapsed.Ticks} ciclos");
            }
            long media = 0;
            long soma = 0;
            for(int j=0; j<rodar; j++)
            {
                soma += vetor[j];
            }
            media = soma / rodar;

            long somaDoDesvio = 0;
            long diff = 0;
            for(int k=0; k<rodar; k++)
            {
                diff = vetor[k] - media;
                somaDoDesvio += (long)Math.Pow(diff, 2);
            }
            long desvioPadrao = (long)Math.Sqrt(somaDoDesvio / rodar);
            

            Console.WriteLine($"Tempo medio passado: {media} ciclos");
            Console.WriteLine($"Desvio padrao: {desvioPadrao}");
        }
    }
}
