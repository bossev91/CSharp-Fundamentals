using System;
using System.Linq;

namespace Exam_WarShips
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pirateShip = Console.ReadLine().Split(">",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] warShip = Console.ReadLine().Split(">",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int healthCapacity = int.Parse(Console.ReadLine());
            int countProblemSector = 0;

            string input = Console.ReadLine();

            bool isLosing = false;

            while (input != "Retire")
            {
                string[] cmdArg = input.Split();
                string command = cmdArg[0];

                if (command == "Fire")
                {
                    int index = int.Parse(cmdArg[1]);
                    int damage = int.Parse(cmdArg[2]);

                    if (index >= 0 && index < warShip.Length)
                    {
                        warShip[index] -= damage;

                        if (warShip[index] <= 0)
                        {
                            isLosing = true;
                            Console.WriteLine($"You won! The enemy ship has sunken.");
                            break;
                        }

                    }
                    if (isLosing == true)
                    {
                        break;
                    }

                    else
                    {
                        input = Console.ReadLine();
                        continue;
                    }


                }
                else if (command == "Defend")
                {
                    int startIndex = int.Parse(cmdArg[1]);
                    int endIndex = int.Parse(cmdArg[2]);
                    int damage = int.Parse(cmdArg[3]);

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        pirateShip[i] -= damage;

                        if (pirateShip[i] <= 0)
                        {
                            isLosing = true;
                            Console.WriteLine("You lost! The pirate ship has sunken.");
                            break;
                        }
                    }
                    if(isLosing == true)
                    {
                        break;
                    }

                    //  if(!isLosing)
                    //  {
                    //      break;
                    //  }
                }
                else if (command == "Repair")
                {
                    int index = int.Parse(cmdArg[1]);
                    int health = int.Parse(cmdArg[2]);

                    if(index < 0 && index >= pirateShip.Length)
                    {
                        input = Console.ReadLine();
                        break;
                    }                   
                    else
                    {
                        pirateShip[index] += health;

                        if (pirateShip[index] > healthCapacity)
                        {
                            pirateShip[index] = healthCapacity;
                        }
                    }
                    
                }
                else if (command == "Status")
                {
                    for (int i = 0; i < pirateShip.Length; i++)
                    {
                        double minPrecent = healthCapacity * 0.20;
                        if (pirateShip[i] < minPrecent)
                        {
                            countProblemSector++;
                        }
                    }
                    Console.WriteLine($"{countProblemSector} sections need repair.");
                }

                input = Console.ReadLine();
            }

            if (!isLosing)
            {
                Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
                Console.WriteLine($"Warship status: {warShip.Sum()}");
            }
        }
    }
}
