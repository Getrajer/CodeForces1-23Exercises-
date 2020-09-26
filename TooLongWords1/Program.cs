using System;
using System.Collections.Generic;

namespace TooLongWords1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWords = Convert.ToInt32(Console.ReadLine());

            List<string> words = new List<string>();

            for(int i = 0; i < numberOfWords; i++)
            {
                words.Add(Console.ReadLine());
            }

            for(int i = 0; i < words.Count; i++)
            {
                if(words[i].Length > 10)
                {
                    string firstLetter = words[i][0].ToString();
                    string lastLetter = words[i][words[i].Length - 1].ToString();

                    int letters_between = 0;

                    for(int j = 1; j < words[i].Length - 1; j++)
                    {
                        letters_between++;
                    }

                    Console.WriteLine(firstLetter + letters_between + lastLetter);
                }
                else
                {
                    Console.WriteLine(words[i]);
                }
            }
        }
    }
}
