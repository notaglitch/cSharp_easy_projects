using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***MY CALCULATOR***");
            Console.WriteLine("[ 1 ] Addition");
            Console.WriteLine("[ 2 ] Subtraction");
            Console.WriteLine("[ 3 ] Multiplication");
            Console.WriteLine("[ 4 ] Division");
            Console.Write("Choose an operations: ");
            string choice = Console.ReadLine();
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            if (choice == "1"){
                Console.WriteLine(Addition(num1, num2));
            }
            else if (choice == "2"){
                Console.WriteLine(Subtraction(num1, num2));
            }
            else if (choice == "3"){
                Console.WriteLine(Multiplication(num1, num2));
            }
            else if (choice == "4"){
                Console.WriteLine(Division(num1, num2));
            }
            else {
                Console.Write("An Error Occured! ");
            }

            Console.ReadLine();
        }
        static int Addition(int a, int b){
            return a + b;
        }
        static int Subtraction(int a, int b){
            return a - b;
        }
        static int Multiplication(int a, int b){
            return a * b;
        }
        static int Division(int a, int b){
            if (b == 0)
                {
                    Console.WriteLine("Error: Division by zero is not allowed. ");
                    return 0;
                }
            return a / b;
        }
        
    }
}

