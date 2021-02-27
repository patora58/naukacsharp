using System;
/* 1:1     1:2  1:3 
 *2:1   2:2     2:3 
*/
namespace n07_petlawpetli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Czesc Petla");
            for (int w = 1; w <= 9; w++) 
            {
                for (int k = 1; k <= 6; k++)
                {
                    Console.Write($"\t{w}:{k}");
                }
                Console.WriteLine();
            }

                


        }
    }
}
