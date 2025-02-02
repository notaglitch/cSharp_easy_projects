using System;

namespace MyNamespace 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a color: ");
            string color = Console.ReadLine();

            Console.WriteLine("Enter a plural noun: ");
            string pluralnoun = Console.ReadLine();

            Console.WriteLine("Enter a celebrity name: ");
            string celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralnoun + " are blue");
            Console.WriteLine("I Love " + celebrity);

            Console.ReadLine();
        }
    }
}