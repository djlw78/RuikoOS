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
        public static void fillBackground(ConsoleColor c) //Might want to try this by changing the cursor position, still get a black line at the bottom
        {
            for (int n = 0; n < 2; n++)
            {
                Console.Clear();
            Console.CursorVisible = false;
            Console.BackgroundColor = c;
            
                for (int i = 0; i < 24; i++)
                {
                    for (int z = 0; z < 80; z++)
                    {
                        if (i == 24 && z == 79)
                        {
                            break;
                        }

                        Console.Write(" ");

                    }
                    //Console.WriteLine();
                }
            
            Console.SetCursorPosition(0,0);
            Console.CursorVisible = true;
            }
        }
        public static void drawBox(int x1, int y1, int x2, int y2, ConsoleColor c)
        {
            //Console.Clear();
            Console.CursorVisible = false;
            Console.BackgroundColor = c;
            Console.SetCursorPosition(x1,y1);

            for (int i = y1; i <= y2; i++)
            {
                Console.CursorLeft = x1;
                for (int z = x1; z <= x2; z++)
                {
                    //if (i == 24 && z == 79)
                    //{
                    //    break;
                    //}

                    Console.Write(" ");

                }
                Console.CursorTop++;
                //Console.WriteLine();
            }

            //Console.SetCursorPosition(0, 0);
            Console.CursorVisible = true;
        }
    }
}
