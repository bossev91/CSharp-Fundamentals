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
            List<string> blackList = new List<string>();            
            byte lostCount = 0;
            string input = Console.ReadLine();
            while (input != "Report")
            {
                string[] cmdArg = input.Split();
                string command = cmdArg[0];
                if (command == "Blacklist")
                {
                    if (friends.Contains(cmdArg[1]))
                    {
                        string name = cmdArg[1];
                        blackList.Add(cmdArg[1]);
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
                    byte index = byte.Parse(cmdArg[1]);
                    string name = friends[index];
                    if (name != "Blacklisted" && name != "Lost")
                    {
                        Console.WriteLine($"{name} was lost due to an error.");
                        friends[index] = "Lost";
                    }
                }
                else if(command == "Change")
                {
                    byte index = byte.Parse(cmdArg[1]);
                    string oldName = friends[index];
                    string newName = cmdArg[2];
                    if (index >= 0 && index < friends.Count)
                    {
                        friends.RemoveAt(index);
                        friends.Insert(index, cmdArg[2]);
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
                if(item == "Lost")
                {
                    lostCount++;
                }
            }
            Console.WriteLine($"Blacklisted names: {blackList.Count}");
            Console.WriteLine($"Lost names: {lostCount}");
            Console.WriteLine(string.Join(" ", friends));
        }
    }
}
