using System;
using System.Collections.Generic;
using System.Linq;

namespace TestDotNetVrSystem
{
    public class Task6
    {
        /*
         * Dada uma lista de inteiros, crie um método que devolva a proporção de números positos, negativos e zeros, respectivamente.
         * Obs.: Retornar valores com 6 casas decimais
         * Ex.:
         * Entrada:
         * -4 3 -9 0 4 1    
         * Saída: 
         * 0.500000
         * 0.333333
         * 0.166667
         */
        public static List<decimal> GetRatios(List<int> numbers)
        {
            List<decimal> ratios = new List<decimal>();
            var total = (decimal)numbers.Count();

            ratios.Add(Decimal.Round(numbers.Where(x => x > 0).Count()  / total, 6));
            ratios.Add(Decimal.Round(numbers.Where(x => x < 0).Count() / total, 6));
            ratios.Add(Decimal.Round(numbers.Where(x => x == 0).Count()  / total, 6));

            return ratios;
        }
    }
}
