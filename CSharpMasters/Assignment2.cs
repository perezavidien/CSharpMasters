using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMasters
{
    public class Assignment2
    {
        // yield
        // reference: https://www.c-sharpcorner.com/UploadFile/5ef30d/understanding-yield-return-in-C-Sharp/

        public static void Run()
        {
            Console.WriteLine("Enter a start number: ");
            int.TryParse(Console.ReadLine(), out var start);

            Console.WriteLine("Enter number of iterations: ");
            int.TryParse(Console.ReadLine(), out var end);

            Console.WriteLine("Sequence numbers are:");

            foreach (var item in GetList(start, end))
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }

        private static IEnumerable<int> GetList(int min, int max)
        {
            for (int i = 0; i < max; i++)
            {
                yield return min + 2 * i;
            }
        }
    }
}
