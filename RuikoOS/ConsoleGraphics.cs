using System;
using System.Collections.Generic;
using System.Text;

namespace RuikoOS
{
    /*
     * ConsoleGraphics.cs
     * Console Graphics Services for RuikoOS
     * 
     */
     
    class ConsoleGraphics
    {
        public static void setBackground(ConsoleColor c) //Might want to try this by changing the cursor position, still get a black line at the bottom
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.BackgroundColor = c;
            for (int i = 0; i < 25; i++)
            {
                for (int z = 0; z < 80; z++)
                {
                    Console.Write(" ");
                }
                //Console.WriteLine();
            }
            Console.SetCursorPosition(0,0);
            Console.CursorVisible = true;
        }
        public static void drawBox(int x, int y, ConsoleColor c)
        {
            
        }
    }
}
