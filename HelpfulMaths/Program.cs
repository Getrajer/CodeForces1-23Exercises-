using System;
using System.Collections.Generic;

namespace HelpfulMaths
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToString();

            List<int> numbers = new List<int>();

            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] != '+') { 

                    string n = "";
                    n += input[i];
                    numbers.Add(Convert.ToInt32(n));
                }
            }

            //Selection sort

            numbers.Sort();

            for(int i = 0; i < numbers.Count; i++)
            {
                if(i != numbers.Count - 1)
                {
                    Console.Write(numbers[i] + "+");
                }
                else
                {
                    Console.Write(numbers[i]);
                }
            }

        }
    }
}
