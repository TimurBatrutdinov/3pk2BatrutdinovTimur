using System;
using System.Linq;

namespace pz_18
{
    class Program
    {
        static int i1(int a1, int d, int n)
        {

            if (n < 0) { Console.WriteLine("error"); return 0; }
            if (n == 0) { Console.WriteLine(0); return 0; }
            if (n == 1) { Console.WriteLine(a1); return a1; }
            else { a1 = a1 + d; n = n - 1; return i1(a1, d, n); }

        }

        static void Main(string[] args)

        {
            int n = Convert.ToInt16(Console.ReadLine());
            i1(100, 10, n);

        }
    }
}