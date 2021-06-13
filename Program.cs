using System;

namespace Last6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] recentList = new string[5];
            string[] hole = new string[1];
            while (true)
            {
                Console.WriteLine("Please input a number from 0 - 3 to choose the following menu:");
                Console.WriteLine("[0] Show all recent files");
                Console.WriteLine("[1] Open new file");
                Console.WriteLine("[2] Open recent file");
                Console.WriteLine("[3] Exit");
                int command = int.Parse(Console.ReadLine());
                if (command == 0)
                {
                   for(int i = 0; i < recentList.Length; i++)
                    {
                        Console.WriteLine("[{0}] {1}",i,recentList[i]);
                    }
                }
                else if (command == 1)
                {
                    for (int i = recentList.Length-1;i>0;i--)
                    {
                        recentList[i] = recentList[i-1]; 
                    }
                    recentList[0] = Console.ReadLine();
                }
                else if (command ==2)
                {
                   
                    int target = int.Parse(Console.ReadLine());
                    if (recentList[target] == hole[0])
                    {
                        Console.WriteLine("No recent file.");
                    }
                    else
                    {
                        for (int i = recentList.Length - 1; i > 0; i--)
                        {
                            recentList[i] = recentList[i - 1];
                        }
                        recentList[0] = recentList[target + 1];
                        
                    }
                }
                else if(command == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid menu number.");
                }
            }
        }
    }
}
