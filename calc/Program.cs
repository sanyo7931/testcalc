using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            calc calc = new calc();
            int s1 = calc.Add(3, 5);
            int s2 = calc.Sub(7, 2);
            Console.WriteLine("3+5=" + s1);
            Console.WriteLine("7-2=" + s2);
            Console.ReadKey();
        }
    }
}
