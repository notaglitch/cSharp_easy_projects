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
            int lives = 0;

            do
            {
                if (lives == 4){
                    Console.WriteLine("YOU LOST...");
                    break;
                }
                Console.Write("Make a Guess: ");
                guess = Console.ReadLine();
                lives++;
            } while (guess != secretWord);
            if (guess == secretWord){
            Console.WriteLine("YESSS! You got it!");
            }
            
            Console.ReadLine();
        }
    }
}