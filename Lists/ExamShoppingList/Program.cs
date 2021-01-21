using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine().Split("!",StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                string[] cmdArgs = input.Split();
                string command = cmdArgs[0];
                string item = cmdArgs[1];


                if (command == "Urgent")
                {
                    if (!groceries.Contains(item))
                    {
                        groceries.Insert(0, item);
                    }
                }
                else if (command == "Unnecessary")
                {
                    if(groceries.Contains(item))
                    {
                        groceries.Remove(item);
                    }
                }
                else if (command == "Correct")
                {
                    if(groceries.Contains(item))
                    {
                        int oldIndex = groceries.IndexOf(item);
                        groceries.RemoveAt(oldIndex);
                        groceries.Insert(oldIndex, cmdArgs[2]);
                    }
                }
                else if (command == "Rearrange")
                {
                    if(groceries.Contains(item))
                    {
                        groceries.Remove(item);
                        groceries.Add(item);
                    }
                }


                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ",groceries));
        }
    }
}
