using System;
using System.Collections.Generic;

namespace StonesOnTheTable_
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            string stones = Console.ReadLine();

            List<string> newList = new List<string>();

            for(int i = 0; i < stones.Length; i++)
            {
                newList.Add(stones[i].ToString());
            }

            int counter = 0;
            
            for(int i = 0; i < newList.Count; i++)
            {
                if(i + 1 != newList.Count)
                {
                    if (newList[i] == newList[i + 1])
                    {
                        newList.RemoveAt(i + 1);
                        counter++;
                        i--;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
