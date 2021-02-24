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
            int primo = valor.Primo(n);
            int[] vetor;
            vetor = new int[10];
            //var count = 0;

            if (primo == 1)
                Console.WriteLine("Eh Primo");
            else
                Console.WriteLine("Nao eh Primo");

            for(int i=0; i<10; i++)
            {
                sw.Start();
                valor.Primo(n);
                sw.Stop();
                vetor[i] = (int)sw.ElapsedTicks;
                Console.WriteLine($"Tempo {i}: {sw.ElapsedTicks}ms");
            }
            var media = 0;
            var soma = 0;
            for(int j=0; j<10; j++)
            {
                soma = vetor[j] + soma;
            }
            media = soma / 10;
            
            Console.WriteLine($"Tempo passado: {media}ms");
        }
    }
}
