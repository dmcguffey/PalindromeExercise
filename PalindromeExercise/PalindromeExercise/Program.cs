using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WordSmith WordSmith = new WordSmith();

            WordSmith.IsAPalindrome("racecar");
        }
    }
}
