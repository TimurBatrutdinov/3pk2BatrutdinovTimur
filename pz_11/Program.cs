using System;

namespace pz_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            (str[0], str[str.Length - 1]) = (str[str.Length - 1], str[0]);
            Console.WriteLine(string.Join(' ', str));
        }
    }
}
