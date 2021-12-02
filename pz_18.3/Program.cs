using System;


namespace pz_18
{
class Program
{
    static void Main()
    {
        numbers(5, 65);
    }
    static void numbers(int a, int b)
    {
        if (a < b)
        {
            Console.Write(a + " ");
            numbers(a + 1, b);
        }
        else if (b < a)
        {
            Console.Write(a + " ");
            numbers(a - 1, b);
        }
        else if (b == a) Console.WriteLine(b);
        else
        {
            Console.Write("");
            Console.WriteLine("№3");
            numbers(5, 65);
        }
    }
}
}
