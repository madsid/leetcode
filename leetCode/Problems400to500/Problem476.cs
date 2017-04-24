using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode
{
    class Problem476
    {
        public static void Solution() {
            int a = 5;
            String b = String.Empty;
            while (a > 0) {
                b += a % 2;
                a /= 2;
            }
            Char[] c = new char[b.Length];
            for (int i = 0; i < b.Length; i++) {
                if (b[i] == '1')
                {
                    c[i] = '0';
                }
                else {
                    c[i] = '1';
                }
            }
            int d = 0;
            int e = c.Length;
            while (e > 0)
            {
                var t = c[2];
                d += t * ( 2 ^ (e - c.Length) );
                e--;
            }
            Console.WriteLine(d);
        }
    }
}
