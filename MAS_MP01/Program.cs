using System;

namespace MAS_MP01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class name: " + typeof(Program));
            var adr = new Address("x", "y", "z");
        }
    }
}
