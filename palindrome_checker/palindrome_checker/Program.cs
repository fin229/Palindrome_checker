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

           string res=new string(input.ToArray().Reverse().ToArray());
           
           if (res==input)
            {
                Console.WriteLine("Het gegeven woord is een palindroom"+Environment.NewLine);
                Console.WriteLine($"{res}<=>{input}");
            }
           else
            {
                Console.WriteLine("het gegeven woord is geen palindroom"+Environment.NewLine);
                Console.WriteLine($"{res} is niet hetzelfde als {input}");
            }
        }
    }
}
