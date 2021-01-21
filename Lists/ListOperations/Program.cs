using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfInts = Console.ReadLine()
                                              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                              .ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArg = command.Split();
                string operation = cmdArg[0];

                if(operation == "Add")
                {
                    listOfInts.Add(cmdArg[1]);
                }
                else if (operation == "Insert")
                {
                    int index = int.Parse(cmdArg[2]);
                    if(IsValidIndex(index , listOfInts.Count - 1))
                    {
                        Console.WriteLine("Invalid index");
                        
                    }
                    else
                    {
                        listOfInts.Insert(index, cmdArg[1]);
                    }
                    
                }
                else if (operation == "Remove")
                {
                    int index = int.Parse(cmdArg[1]);
                    if (IsValidIndex(index, listOfInts.Count - 1))
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        listOfInts.RemoveAt(index);
                    }    
                }
                else if (operation == "Shift")
                {

                    int rotation = int.Parse(cmdArg[2]);
                   
                    if(cmdArg[1] == "left")
                    {
                        for (int i = 0; i < rotation; i++)
                        {

                            string current = listOfInts[0];

                            for (int j = 0; j < listOfInts.Count - 1; j++)
                            {
                                listOfInts[j] = listOfInts[j + 1];
                            }
                                listOfInts[listOfInts.Count - 1] = current;
                           
                           

                        }
                    }
                    else // cmdArg[1] == "Right"
                    {
                        for (int i = 0; i < rotation; i++)
                        {

                            string current = listOfInts[listOfInts.Count - 1];

                            for (int j = listOfInts.Count - 1; j > 0; j--)
                            {
                                listOfInts[j] = listOfInts[j - 1];
                            }
                            listOfInts[0] = current;



                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",listOfInts));
        }

        private static bool IsValidIndex(int index, int count)
        {
            return index < 0 || index > count;
        }
    }
}
