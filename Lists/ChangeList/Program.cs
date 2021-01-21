using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while(command != "end")
            {
                string[] cmdArg = command.Split();


                if (cmdArg[0] == "Delete")
                {

                    numbers.RemoveAll(n => n == int.Parse(cmdArg[1]));
                }
                
                if (cmdArg[0] == "Insert")
                {
                    numbers.Insert(int.Parse(cmdArg[2]), int.Parse(cmdArg[1]));
                }

                command = Console.ReadLine();

            }

            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
