using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //I will not skateboard in the halls.

            for (int i = 0; i < 10; i++)// int i = 0; - start; i < 10; - end; i++ = i = i +1 -step
            {
                Console.WriteLine("I will not skateboard in the halls.".ToUpper());
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
