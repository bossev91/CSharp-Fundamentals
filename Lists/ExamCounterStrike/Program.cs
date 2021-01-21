using System;

namespace ExamCounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int wonsCoount = 0;

            string input = Console.ReadLine();
            bool isEnought = true;

            while(input != "End of battle")
            {
                int command = int.Parse(input);

                energy -= command;

                if(energy >= 0)
                {
                    wonsCoount++;
                    if(wonsCoount % 3 == 0)
                    {
                        energy += wonsCoount;
                    }
                    if(energy == 0)
                    {
                        break;
                    }
                }
                else
                {
                    isEnought = false;
                    energy = 0;
                    Console.WriteLine($"Not enough energy! Game ends with {wonsCoount} won battles and {energy} energy");
                    break;
                }

                input = Console.ReadLine();
            }

            if(isEnought)
            {
                Console.WriteLine($"Won battles: {wonsCoount}. Energy left: {energy}");
            }
        }
    }
}
