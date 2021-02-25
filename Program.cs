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

            var n = 2147483647;
            var rodar = 20;
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
                Console.WriteLine($"Tempo {i+1}: {sw.Elapsed.TotalMilliseconds}ms");
            }
            var media = 0;
            var soma = 0;
            for(int j=0; j<rodar; j++)
            {
                soma = vetor[j] + soma;
            }
            media = soma / rodar;
            
            Console.WriteLine($"Tempo passado: {media}ms");
        }
    }
}
