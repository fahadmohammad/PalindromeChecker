using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace PalindromeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a text");
            string text = Console.ReadLine();

            Console.WriteLine($"IsTextPalindrome: {IsTextPalindrome(text)}");

            Console.WriteLine($"IsIntNumberPalindrome: {IsNumberPalindrome(123456)}");
            Console.WriteLine($"IsDoubleNumberPalindrome: {IsDoubleNumberPalindrome(123.123)}");

            Console.ReadLine();
        }

        private static bool IsNumberPalindrome(int number)
        {
            return IsTextPalindrome(number.ToString());
        }

        private static bool IsDoubleNumberPalindrome(double number)
        {
            return IsTextPalindrome(number.ToString());
        }

        private static bool IsTextPalindrome(string text)
        {
            Regex charToBeRemoved = new Regex(@"[^a-zA-Z0-0]");
            text = charToBeRemoved.Replace(text, "");
            text = text.ToUpper();

            var backward = text.Reverse().ToArray();
            string backwardText = new string(backward);

            bool output = string.Compare(text, backwardText) == 0;

            return output;
        }
    }
}
