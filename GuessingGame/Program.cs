using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Guessing Game***");
            string secretWord = "giraffe";
            string guess = "";

            do
            {
                Console.Write("Make a Guess: ");
                guess = Console.ReadLine();
            } while (guess != secretWord);
            Console.WriteLine("YESSS! You got it!");
            
            Console.ReadLine();
        }
    }
}