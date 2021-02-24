using System;
using System.Collections.Generic;
using System.Text;

namespace TestaPrimo
{
    class TestaPrimo
    {
        public int Primo(int n)
        {
            var ehPrimo = 1;
            var d = 2;
    
            if (n <= 1)
    	        ehPrimo = 0;

            while (ehPrimo == 1 && d <= n /2) {
    	        if (n % d  == 0)
        	        ehPrimo = 0;
    	        d = d + 1;
            }
            return ehPrimo;
        }
        
    }
}
