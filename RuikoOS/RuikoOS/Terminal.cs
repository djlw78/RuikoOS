using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuikoOS
{
    class Terminal
    {

        public static void runPrompt()
        {
            printPromptString();
            Console.Write(">");
            var input = Console.ReadLine();
            String[] cmd = input.Split(' ');
            Boolean found = SystemCommand.CmdSearch(cmd);
            if (!found)
            {
                Console.WriteLine("Command not found.");
            }
        }

        private static void printPromptString()
        {
            Console.Write(Environment.currentDirectory);
        }
    }
}
