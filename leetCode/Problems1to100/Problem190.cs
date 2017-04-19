using System;
using System.Collections.Generic;
using System.Text;

namespace leetCode
{
    class Problem190
    {
        public static void Solution()
        {
            int a = 43261596;
            int b = ~(a & 2);
            Console.WriteLine(b);
        }
    }
}
