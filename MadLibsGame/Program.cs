using System;

namespace MyNamespace 
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralnoun, celebrity;

            Console.WriteLine("Enter a color: ");
            color = Console.ReadLine();

            Console.WriteLine("Enter a plural noun: ");
            pluralnoun = Console.ReadLine();

            Console.WriteLine("Enter a celebrity name: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralnoun + " are blue");
            Console.WriteLine("I Love " + celebrity);

            Console.ReadLine();
        }
    }
}