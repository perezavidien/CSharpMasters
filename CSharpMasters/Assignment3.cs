using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpMasters
{
    public class Assignment3
    {
        public static void Run()
        {
            Console.WriteLine("Enter strings separated by commas (,): ");

            var strCollection = Console.ReadLine().Split(',');

            foreach (var str in strCollection)
            {
                if (IsPalindrome(str))
                {
                    Console.WriteLine(str);
                }
            }

            Console.ReadLine();
        }

        public static bool IsPalindrome(string stringInput)
        {
            // reference: https://www.tutorialspoint.com/Chash-program-to-check-if-a-string-is-palindrome-or-not

            stringInput = RemoveOtherCharacters(stringInput);

            char[] strArray = stringInput.ToCharArray();
            Array.Reverse(strArray);
            var strReverse = new string(strArray);

            return stringInput.Equals(strReverse, StringComparison.OrdinalIgnoreCase);
        }

        public static string RemoveOtherCharacters(string stringInput)
        {
            // reference: https://stackoverflow.com/questions/1120198/most-efficient-way-to-remove-special-characters-from-string

            stringInput.Trim();

            StringBuilder sb = new StringBuilder();

            foreach (char c in stringInput)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_')
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
    }
}
