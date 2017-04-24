using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode
{
    class Problem557
    {
        public static void Solution() {
            String a = "Let's take LeetCode contest";
            String b = String.Empty;
            String[] c = a.Split(null);
            int count = 0;
            while (count < c.Length) {
                String d = c[count];
                int coun = d.Length;
                int i = 0;
                char[] e = new char[coun];
                while (coun > 0 ) {
                    e[i++] = d[--coun];
                }
                b += new String(e)+ " ";
                count++;
            }
            Console.WriteLine(b);
        }
    }
}
