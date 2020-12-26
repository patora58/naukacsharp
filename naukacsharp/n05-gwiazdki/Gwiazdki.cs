using System;
using System.Collections.Generic;
using System.Text;

namespace n05_gwiazdki
{
    public class Gwiazdki
    {
         int Wiersze = 3;
        public Gwiazdki(int ileWierszy)
        {
            this.Wiersze = ileWierszy;
        }
        /*
       ------------+
     1|   *     D) |
     2|  **        |
     3| ***        |
     4|****        |
        */

        public void GwiazdkiD()
        {
            int wiersz = 1;
            while (wiersz <= Wiersze)
            {
                for (int s = Wiersze - wiersz; s > 0; s--)
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
        public void GwiazdkiC()
        {
            int wiersz = 1;
            while (wiersz <= Wiersze)
            {
                for (int s = 1; s < wiersz; s++)
                    Console.Write(" ");
                for (int g = Wiersze - wiersz + 1; g >= 1; --g)
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
        public void GwiazdkiB()
        {
            int wiersz = 1;
            while (wiersz <= Wiersze)
            {
                for (int g = Wiersze - wiersz + 1; g >= 1; --g)
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

        public void GwiazdkiA()
        {
            int wiersz = 1;
            while (wiersz <= Wiersze)
            {
                for (int g = 1; g <= wiersz; ++g)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

                wiersz = wiersz + 1;
            }
        }
        public void Linia()
        {
            Console.WriteLine("===");

        }
    }
}
