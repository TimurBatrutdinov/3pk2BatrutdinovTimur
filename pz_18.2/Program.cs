using System;

namespace pz_18
{ 
class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine(Geom(3, 4, 0.1));
        }
        static double Arifm(int n, double a, double d)
        {
            if (n < 1) return 0;
            else if (n == 1) return a;
            return Arifm(n - 1, a, d) + d;
        }

        static double Geom(int g, double b, double q)
        {
            if (g < 1) return 0;
            else if (g == 1) return b;
            return Geom(g - 1, b, q) * q;
        }

        static String Last(int c, int z)
        {
            if (c > z)
            {
                return c + " " + Last(c - 1, z);
            }
            if (z > c)
            {
                return c + " " + Last(c + 1, z);
            }
            else
            {
                return ($"{c}");
            }
        }
    }
}


