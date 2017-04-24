using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode
{
    class Problem461
    {
        public static void Solution() {
            int a = 1;
            int b = 4;
            int c = a ^ b;
            int distance = 0;
            while (c > 0) {
                int t = c & 1; 
                if (t == 1) {
                    distance++;
                }
                c /= 2; 
            }
            Console.WriteLine(distance);
        }
    }
}
