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

            int n = 27; // Para grandes numeros recomendo diminuir o numero e rodar abaixo
            int rodar = 30;
            int primo = valor.Primo3(n);
            int[] vetor = new int[rodar];
            int soma = 0;

            if (primo == 1)
                Console.WriteLine("Eh Primo");
            else
                Console.WriteLine("Nao eh Primo");

            for(int i=0; i<rodar; i++)
            {
                sw.Start();
                valor.Primo3(n);
                sw.Stop();
                vetor[i] = (int)sw.Elapsed.Ticks;
                //Console.WriteLine($"Tempo {i+1}: {sw.Elapsed.Ticks} ciclos");
                soma += vetor[i];
            }
            
            int media = soma / rodar;

            int somaDoDesvio = 0;

            for(int k=0; k<rodar; k++)
            {
                int diff = vetor[k] - media;
                somaDoDesvio += (int)Math.Pow(diff, 2);
            }

            int desvioPadrao = (int)Math.Sqrt(somaDoDesvio / rodar);

            Console.WriteLine($"Tempo medio passado: {media} ciclos");
            Console.WriteLine($"Desvio padrao: {desvioPadrao}");
        }
    }
}
