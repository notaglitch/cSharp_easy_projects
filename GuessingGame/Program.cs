using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";

            string guess = "";
            while (guess != secretWord)
            {
                Console.Write("Make a guess: ");
                guess = Console.ReadLine();
            }
            Console.WriteLine("YESSS! You got it!");
            
            Console.ReadLine();
        }
    }
}