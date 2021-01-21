using System;
using System.Linq;

namespace ExamShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;
            string input = Console.ReadLine();

            while(input != "End")
            {

                int indexToShot = int.Parse(input);

                if(indexToShot < 0 || indexToShot >= targets.Length || targets[indexToShot] == -1)
                {
                    input = Console.ReadLine();
                    continue;
                }

                count++;

                int valueOfTarget = targets[indexToShot];
                targets[indexToShot] = -1;

                for (int i = 0; i < targets.Length; i++)
                {
                    if(targets[i] != -1)
                    {
                        if(targets[i] > valueOfTarget)
                        {
                            targets[i] -= valueOfTarget;
                        }
                        else
                        {
                            targets[i] += valueOfTarget;
                        }
                    }
                }


                input = Console.ReadLine();
            }
            
            Console.WriteLine($"Shot targets: {count} -> {string.Join(" ", targets)}");
        }
    }
}
