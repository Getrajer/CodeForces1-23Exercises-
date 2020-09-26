using System;

namespace WrongSubstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int number = 0;
            int d = 0;

            string txt = "";
            int c = 0;

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
                        number = Convert.ToInt32(txt);
                        txt = "";
                    }
                }
            }

            d = Convert.ToInt32(txt);


            for(int i = 0; i < d; i++)
            {
                if(number % 10 != 0)
                {
                    number -= 1;
                }
                else
                {
                    number = number / 10;
                }
            }

            Console.WriteLine(number);

        }
    }
}
