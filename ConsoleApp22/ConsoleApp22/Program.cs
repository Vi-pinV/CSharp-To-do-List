using System.Collections.Generic;

namespace ConsoleApp22
{
    class Program
    {
        
        enum UserChoice
        {
            AddTask = 1, ListTask = 2, Exit=3
        }
        static void Main(string[] args)
        {
            List<string> toDoList = new List<string>();
            while (true)
            {
                
                Console.WriteLine("1. AddTask");
                Console.WriteLine("2. Exit");
                int choice = int.Parse(Console.ReadLine());

                if (choice == (int)UserChoice.AddTask) {
                    Console.WriteLine("Enter task:");
                    string task = Console.ReadLine();
                    toDoList.Add(task);
                    Console.Clear();
                    Console.WriteLine("Task added succesfully");
                }
                else if(choice == (int)UserChoice.ListTask)
                {
                    if (toDoList.Count > 0)
                    {
                        Console.WriteLine("TO-Do-List");
                        for (int i = 0; i < toDoList.Count; i++)
                        {
                            Console.WriteLine("-" + toDoList[i]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Empty list");
                    }
                }
                else if (choice == (int)UserChoice.Exit)
                {
                    break;
                }

            }
        }
    }
}


