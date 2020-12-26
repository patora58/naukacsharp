using System;

namespace n05_gwiazdki
{   /*
     +------------+
     |*        A) |
     |**          |
     |***         |
     |****        |
     +------------+
     |****     B) |
     |***         |
     |**          |
     |*           |
     +------------+
     |****     C) |
     | ***        |
     |  **        |
     |   *        |
     +------------+
     |   *     D) |
     |  **        |
     | ***        |
     |****        |
     +------------+
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("gwiazdki");
            Linia();
            GwiazdkiA();
            Linia();
            GwiazdkiB();
            Linia();
            GwiazdkiC();
            Linia();
            GwiazdkiD();
            Linia();
           }
        /*
       ------------+
     1|   *     D) |
     2|  **        |
     3| ***        |
     4|****        |
        */

        private static void GwiazdkiD()
        {
            int wiersz = 1;
            while (wiersz <= 4)
            {
                for (int s = 4-wiersz; s > 0; s--)
                    Console.Write(" ");
                for (int g = 1; g <= wiersz; ++g)
                    Console.Write("*");
                Console.WriteLine();
                wiersz++;

            }


        }

        /*
1|****     C) |
2| ***        |
3|  **        |
4|   *        

*/
        private static void GwiazdkiC()
        {
            int wiersz = 1;
            while (wiersz <= 4)
            {
                for (int s = 1; s < wiersz; s++)
                    Console.Write(" ");
                for (int g = 4 - wiersz + 1; g >= 1; --g)
                    Console.Write("*");
                Console.WriteLine();
                wiersz++;

            }

        }

        /*
1|****     B) |
2|***         |
3|**          |
4|*           
*/
        private static void GwiazdkiB()
        {
            int wiersz = 1;
            while (wiersz <= 4)
            {
                for (int g = 4 - wiersz + 1; g >= 1; --g)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

                wiersz++;
            }



        }

        /*
+------------+
1  |*        A) |
2  |**          |
3  |***         |
4  |****        |*/

        private static void GwiazdkiA()
        {
            int wiersz = 1;
            while (wiersz <= 4)
            {
                for (int g = 1; g <= wiersz; ++g)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

                wiersz = wiersz + 1;
            }
        }
        private static void Linia()
        {
            Console.WriteLine("===");

        }
    }
}
