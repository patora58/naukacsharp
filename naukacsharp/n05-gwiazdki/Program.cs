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
            Gwiazdki gw = new Gwiazdki();
            gw.Linia();
            gw.GwiazdkiA();
            gw.Linia();
            gw.GwiazdkiB();
            gw.Linia();
            gw.GwiazdkiC();
            gw.Linia();
            gw.GwiazdkiD();
            gw.Linia();
           }

    }
}
