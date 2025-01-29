using System;
using System.Collections.Generic;

namespace MyNamespace
{
    class Program
    {
        static List<string> Tasks = new List<string>();

        static void Main(string[] args)
        {
            string choice = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("***To Do APP***");
                Console.WriteLine("[ 1 ] Show Tasks");
                Console.WriteLine("[ 2 ] Delete a Task");
                Console.WriteLine("[ 3 ] Add a Task");
                Console.WriteLine("[ 4 ] Exit");
                Console.Write("Choose an option: ");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    ShowTasks();
                }
                else if (choice == "2")
                {
                    ShowTasks();
                    Console.Write("Which Task, type the number: ");
                    int taskIndex = int.Parse(Console.ReadLine()) - 1;
                    if (taskIndex >= 0 && taskIndex < Tasks.Count)
                    {
                        Tasks.RemoveAt(taskIndex);
                        Console.WriteLine("Task deleted.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid task number.");
                    }
                }
                else if (choice == "3")
                {
                    Console.Write("Enter the Task: ");
                    string TaskToAdd = Console.ReadLine();
                    Tasks.Add(TaskToAdd);
                    Console.WriteLine("Task added.");
                }
                else if (choice == "4"){
                    Console.WriteLine("Exiting the app...");
                    break;
                }
                else
                {
                    Console.WriteLine("An Error Occurred.");
                }

                Console.WriteLine("Press Enter to return to the main menu...");
                Console.ReadLine();
            }
        }

        static void ShowTasks()
        {
            if (Tasks.Count == 0)
            {
                Console.WriteLine("No tasks available.");
                return;
            }

            int count = 1;
            foreach (string task in Tasks)
            {
                Console.WriteLine(count + ". " + task);
                count++;
            }
        }
    }
}
