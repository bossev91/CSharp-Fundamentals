using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                                         .Split()
                                         .Select(int.Parse)
                                         .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while(command != "end")
            {
                string[] cmdArg = command.Split();

                if(cmdArg[0] == "Add")
                {
                    wagons.Add(int.Parse(cmdArg[1]));
                }
                else
                {
                    int passangers = (int.Parse(cmdArg[0]));

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currentWagon = wagons[i];

                        bool isEnough = passangers + currentWagon <= maxCapacity;

                        if(isEnough)
                        {
                            wagons[i] += passangers;
                            break;
                        }

                    }
                   
                }
                command = Console.ReadLine();

            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
