using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();

            while(command != "end")
            {
                string[] cmdArg = command.Split();

                if(cmdArg[0] == "Insert")
                {
                    string item = cmdArg[1];
                    int index = int.Parse(cmdArg[2]);
                    list.Insert(index, item);
                }
                else if (cmdArg[0] == "Delete")
                {
                    string item = cmdArg[1];
                    list.RemoveAll(cmd => cmd == item);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
