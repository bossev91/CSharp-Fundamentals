using System;
using System.Collections.Generic;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int i = 0; i < commandsCount; i++)
            {
                string[] cmdArg = Console.ReadLine().Split();
                string guestName = cmdArg[0];

                if(cmdArg.Length <= 3)
                {
                    if (guestList.Contains(guestName))
                    {
                        Console.WriteLine($"{guestName} is already in the list!");
                    }
                    else
                    {
                        guestList.Add(guestName);
                    }
                    
                }
                else
                {
                    if(guestList.Contains(guestName))
                    {
                        guestList.Remove(guestName);
                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is not in the list!");
                    }
                }    
                
            }

            Console.WriteLine(string.Join(Environment.NewLine, guestList));
        }
    }
}
