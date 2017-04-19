using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode
{
    class Problem191
    {
        public static void Solution() {
            int a = 11;
            int d = 0;
            while (a > 0)
            {
                int b = a & 1;
                if (b == 1) {
                    d++;
                }
                a /= 2;
            }
            Console.WriteLine(d);
        }
    }
}
