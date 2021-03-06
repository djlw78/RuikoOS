﻿using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace RuikoOS
{
    public class Kernel: Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.WriteLine("");
            Console.WriteLine(SystemInformation.getProduct() + " " + SystemInformation.getShortVersion());
            Console.WriteLine(SystemInformation.getCopyright());
            Console.WriteLine("");
            Console.WriteLine("RuikoOS is running in live mode.");
            Console.WriteLine("");
        }

        protected override void Run()
        {
            Terminal.runPrompt();

        }
    }
}
