using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace RuikoOS
{
    class CGSTest
    {
        public static void consoleTest()
        {
            Canvas canvas;
            canvas = FullScreenCanvas.GetFullScreenCanvas();
            canvas.Clear(Color.Blue);
            Console.Clear();
            Console.WriteLine("DONE");

        }
    }
}
