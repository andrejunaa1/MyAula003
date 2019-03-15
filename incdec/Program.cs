using System;

namespace incdec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int c = ++a + b++;
            int d = --c - b--;

            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
