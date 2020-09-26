using System;

namespace BoyOrGirl
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for(int i = 0; i < input.Length; i++)
            {
                for(int j = i + 1; j < input.Length; j++)
                {
                    if(input[i] == input[j])
                    {
                        input = input.Remove(j, 1);
                        j--;
                    }
                }
            }


            if(input.Length % 2 == 0)
            {
                Console.WriteLine("CHAT WITH HER!");
            }
            else
            {
                Console.WriteLine("IGNORE HIM!");
            }

        }
    }
}
