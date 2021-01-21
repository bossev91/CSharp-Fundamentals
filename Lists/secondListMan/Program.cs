using System;
using System.Collections.Generic;
using System.Linq;

namespace EXAM_ListManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> friends = Console.ReadLine().Split(", ").ToList();          
            byte lostCount = 0;
            byte blackCount = 0;
            string input = Console.ReadLine();
            while (input != "Report")
            {
                string[] cmdArg = input.Split();
                string command = cmdArg[0];
                byte index1 = byte.Parse(cmdArg[1]);
                if (command == "Blacklist")
                {
                    if (friends.Contains(cmdArg[1]))
                    {
                        string name = cmdArg[1];                     
                        Console.WriteLine($"{cmdArg[1]} was blacklisted.");
                        int index = friends.FindIndex(x => x == name);
                        friends.RemoveAt(index);
                        friends.Insert(index, "Blacklisted");
                    }
                    else
                    {
                        Console.WriteLine($"{cmdArg[1]} was not found.");
                    }
                }
                else if (command == "Error")
                {
                    
                    string name = friends[index1];
                    if (name != "Blacklisted" && name != "Lost")
                    {
                        Console.WriteLine($"{name} was lost due to an error.");
                        friends[index1] = "Lost";
                    }
                }
                else if (command == "Change")
                {
                    
                    string oldName = friends[index1];
                    string newName = cmdArg[2];
                    if (index1 >= 0 && index1 < friends.Count)
                    {
                        friends.RemoveAt(index1);
                        friends.Insert(index1, cmdArg[2]);
                        Console.WriteLine($"{oldName} changed his username to {newName}.");
                    }
                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in friends)
            {
                if (item == "Lost")
                {
                    lostCount++;
                }
            }
            foreach (var item in friends)
            {
                if (item == "Blacklisted")
                {
                    blackCount++;
                }
            }
            Console.WriteLine($"Blacklisted names: {blackCount}");
            Console.WriteLine($"Lost names: {lostCount}");
            Console.WriteLine(string.Join(" ", friends));
        }
    }
}
