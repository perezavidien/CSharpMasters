using System;

namespace CSharpMasters
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a start number: ");
            int.TryParse(Console.ReadLine(), out var start);

            Console.WriteLine("Enter number of iterations: ");
            int.TryParse(Console.ReadLine(), out var end);

            Assignment2.Run(start, end);
        }
    }
}
