using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input two values");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Addition of {0} and {1} is {2}", a, b, API.add(a, b));
            Console.WriteLine("End of main program");
        }
    }
}
