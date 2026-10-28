using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_dagoba2627
{
    public class Factorial
    {
        public static int CalculateFactorial(int n)
        {
            if (n == 0) return 1;
            if (n == 1) return 1;
            if (n < 0) return -1;
            return n * CalculateFactorial(n - 1);
        }
    }
}
