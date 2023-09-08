using System;
using System.Linq;

namespace palindrome_checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("Geef een woord in: ");
                input = Console.ReadLine();
            } while(string.IsNullOrWhiteSpace(input));

            string res=input.Split().Reverse().ToString();
            Console.WriteLine(res);
        }
    }
}
