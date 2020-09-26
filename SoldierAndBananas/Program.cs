using System;

namespace SoldierAndBananas
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int k = 0;
            int m = 0;
            int a = 0;

            int c = 0;

            string txt = "";
                
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] != ' ')
                {
                    txt += input[i];

                }
                else
                {
                    if(c == 0)
                    {
                        k = Convert.ToInt32(txt);
                        c++;
                        txt = "";
                    }
                    else if(c == 1)
                    {
                        m = Convert.ToInt32(txt);
                        c++;
                        txt = "";
                    }
                    else
                    {
                        a = Convert.ToInt32(input[i]);
                        txt = "";
                    }
                }

                if (i == input.Length - 1)
                {
                    a = Convert.ToInt32(txt);
                }
            }

            int sum = 0;

            for(int i = 1; i <= a; i++)
            {
                sum += k * i;
            }

            int diffrence = sum - m;


            if(diffrence > 0)
            {
                Console.WriteLine(diffrence);
            }
            else
            {
                Console.WriteLine(0);
            }
            

        }
    }
}
