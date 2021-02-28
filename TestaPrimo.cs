using System;
using System.Collections.Generic;
using System.Text;

namespace TestaPrimo
{
    class TestaPrimo
    {
        public int Primo(long n)
        {
            int ehPrimo = 1;
            int d = 2;
    
            if (n <= 1)
    	        ehPrimo = 0;

            while (ehPrimo == 1 && d <= n /2) {
    	        if (n % d  == 0)
        	        ehPrimo = 0;
    	        d = d + 1;
            }
            return ehPrimo;
        }

        public int Primo2(long n)
        {
            int ehPrimo;
            int d = 3;

            if (n <= 1 || (n != 2 && n % 2 == 0))
                ehPrimo = 0;   
            else
                ehPrimo = 1;        

            while (ehPrimo == 1 && d <= n / 2)
            {
                if (n % d == 0)
                    ehPrimo = 0;
                d = d + 2;        
            }
            return ehPrimo;
        }

        public int Primo3(long n)
        {
            int ehPrimo;
            int d = 3;
            if (n <= 1 || (n != 2 && n % 6 == 1 && n % 6 == 5))
                ehPrimo = 0;    
            else
                ehPrimo = 1;
            while (ehPrimo == 1 && d <= n / 2)
            {
                if (n % d == 0)
                    ehPrimo = 0;
                d = d + 2;
            }
            return ehPrimo;
        }
        
    }
}
