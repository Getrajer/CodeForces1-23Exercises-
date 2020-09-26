using System;
using System.Text;

namespace CompareStringsLexicographically
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().ToLower();
            string second = Console.ReadLine().ToLower();

            byte[] first_bytes = Encoding.ASCII.GetBytes(first);
            byte[] second_bytes = Encoding.ASCII.GetBytes(second);

            bool done = false;

            for (int i = 0; i < first.Length; i++)
            {
                if(first[i] != second[i])
                {
                    if(first_bytes[i] > second_bytes[i])
                    {
                        Console.WriteLine(-1);
                        done = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine(1);
                        done = true;
                        break;
                    }
                }
            }

            if (!done) Console.WriteLine(0);
        }
    }
}
