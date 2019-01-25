using System;

namespace FuzzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            String Answer = string.Empty;

            for (int i = 1; i < 101; i++)
            {
                Answer = string.Empty;
                if (i % 3==0)
                {
                    Answer = "Fuzz";
                }
                if (i % 5 == 0)
                {
                    Answer = "Buzz";
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Answer = "FuzzBuzz";
                }
                Console.WriteLine(i+" " + Answer);
            }
            Console.ReadLine();  
        }
    }
}
