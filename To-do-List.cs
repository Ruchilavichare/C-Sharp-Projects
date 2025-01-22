using System;
using System.Collections.Generic;

namespace TodoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> todoList = new List<string>();

            Console.WriteLine("Welcome to ToDo List App!");

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add a task");
                Console.WriteLine("2. View tasks");
                Console.WriteLine("3. Delete a task");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice (1-4): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddTask(todoList);
                        break;
                    case 2:
                        ViewTasks(todoList);
                        break;
                    case 3:
                        DeleteTask(todoList);
                        break;
                    case 4:
                        Console.WriteLine("Exiting ToDo List App. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void AddTask(List<string> todoList)
        {
            Console.Write("Enter task: ");
            string task = Console.ReadLine();
            todoList.Add(task);
            Console.WriteLine("Task added successfully!");
        }

        static void ViewTasks(List<string> todoList)
        {
            if (todoList.Count == 0)
            {
                Console.WriteLine("No tasks in the list.");
            }
            else
            {
                Console.WriteLine("Tasks:");
                for (int i = 0; i < todoList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {todoList[i]}");
                }
            }
        }

        static void DeleteTask(List<string> todoList)
        {
            ViewTasks(todoList);
            Console.Write("Enter the task number to delete: ");
            int taskNumber = Convert.ToInt32(Console.ReadLine());

            if (taskNumber > 0 && taskNumber <= todoList.Count)
            {
                todoList.RemoveAt(taskNumber - 1);
                Console.WriteLine("Task deleted successfully!");
            }
            else
            {
                Console.WriteLine("Invalid task number. Please try again.");
            }
        }
    }
}
