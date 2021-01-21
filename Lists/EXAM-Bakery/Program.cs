using System;
using System.Xml.Schema;

namespace EXAM_Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerDay = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int days = 30;
            int concurentProduction = int.Parse(Console.ReadLine());
            double precent = 0;
            double dayProduction = biscuitsPerDay * workers;
            double monthProduction = 0;
            for (int i = 1; i <= days; i++)
            {
                if(i % 3 == 0)
                {
                    monthProduction += Math.Floor(dayProduction * 0.75);
                }
                else
                {
                    monthProduction += Math.Floor(dayProduction);
                }
            }
            if(monthProduction > concurentProduction)
            {
                double difference = monthProduction - concurentProduction;
                precent = (difference / concurentProduction) * 100;

                Console.WriteLine($"You have produced {monthProduction} biscuits for the past month.");
                Console.WriteLine($"You produce {precent:f2} percent more biscuits.");
            }
            else
            {
                double difference = concurentProduction - monthProduction;
                precent = (difference / concurentProduction) * 100;
                Console.WriteLine($"You have produced {monthProduction} biscuits for the past month.");
                Console.WriteLine($"You produce {precent:f2} percent less biscuits.");
            }           
        }
    }
}
