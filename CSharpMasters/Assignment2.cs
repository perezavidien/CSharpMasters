using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMasters
{
    public class Assignment2
    {
        // yield

        public static void Run(int start, int end)
        {
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
