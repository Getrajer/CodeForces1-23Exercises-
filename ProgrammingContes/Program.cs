using System;

namespace ProgrammingContes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfProblems = Convert.ToInt32(Console.ReadLine());

            int solved = 0;
            


            for(int i = 0; i < numberOfProblems; i++)
            {
                string a = Console.ReadLine();
                int counter = 0;
                for(int j = 0; j < a.Length; j++)
                {
                    if (a[j] == '1') counter++;
                }

                if(counter >= 2)
                {
                    solved++;
                }

            }

            Console.WriteLine(solved);

        }
    }
}
