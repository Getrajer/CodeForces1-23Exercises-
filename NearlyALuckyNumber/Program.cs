using System;

namespace NearlyALuckyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            bool lucky = true;

            for(int i = 0; i < number.Length; i++)
            {
                if(number.Length == 1)
                {
                    Console.WriteLine("NO");
                    lucky = false;
                    break;
                }

                if(number[i] != '4' && number[i] != '7')
                {
                    Console.WriteLine("NO");
                    lucky = false;
                    break;
                }
            }

            if (lucky) Console.WriteLine("YES");
        }
    }
}
