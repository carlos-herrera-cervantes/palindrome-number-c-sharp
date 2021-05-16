using System;
using PalindromeNumberConsoleApp.Models;

namespace PalindromeNumberConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 121;
            bool result = SuperInteger.IsPalindrome(number);

            Console.WriteLine($"Is the number {number} a palindrome?: {result}");
        }
    }
}
