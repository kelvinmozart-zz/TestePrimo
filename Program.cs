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

            var n = 524287; // Para grandes numeros recomendo diminuir o numero e rodar abaixo
            var rodar = 4;
            int primo = valor.Primo3(n);
            int[] vetor;
            vetor = new int[rodar];
            //var count = 0;

            if (primo == 1)
                Console.WriteLine("Eh Primo");
            else
                Console.WriteLine("Nao eh Primo");

            for(int i=0; i<rodar; i++)
            {
                sw.Start();
                valor.Primo3(n);
                sw.Stop();
                vetor[i] = (int)sw.ElapsedTicks;
                Console.WriteLine($"Tempo {i+1}: {sw.ElapsedTicks} ciclos");
            }
            var media = 0;
            var soma = 0;
            for(int j=0; j<rodar; j++)
            {
                soma = vetor[j] + soma;
            }
            media = soma / rodar;

            var somaDoDesvio = 0;
            var diff = 0;
            for(int k=0; k<rodar; k++)
            {
                diff = vetor[k] - media;
                somaDoDesvio += (int)Math.Pow(diff, 2);
            }
            var desvioPadrao = 0;
            desvioPadrao = (int)Math.Sqrt(somaDoDesvio / 4);
            

            Console.WriteLine($"Tempo passado: {media} ciclos");
            Console.WriteLine($"Desvio padrao: {desvioPadrao}");
        }
    }
}
