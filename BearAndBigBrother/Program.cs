﻿using System;

namespace BearAndBigBrother
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            int l = 0;
            int b = 0;

            int c = 0;
            string txt = "";

            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] != ' ')
                {
                    txt += input[i];
                }
                else
                {
                    if(c == 0)
                    {
                        l = Convert.ToInt32(txt);
                        c++;
                        txt = "";
                    }
                }

                if(i == input.Length - 1)
                {
                    b = Convert.ToInt32(txt);
                }
            }

            int counter = 0;

            do
            {
                l = l * 3;
                b = b * 2;
                counter++;
            } while (l <= b);

            Console.WriteLine(counter);

        }
    }
}
