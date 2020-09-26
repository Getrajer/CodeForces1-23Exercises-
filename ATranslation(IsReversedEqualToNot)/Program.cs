using System;

namespace ATranslation_IsReversedEqualToNot_
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();

            bool isCorrect = true;
            int j = s2.Length - 1;
            for(int i = 0; i< s1.Length; i++)
            {
                if(s2[j] != s1[i])
                {
                    Console.WriteLine("NO");
                    isCorrect = false;
                    break;
                }

                j--;
            }

            if (isCorrect) Console.WriteLine("YES");
        }
    }
}
