using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuikoOS
{
    class SystemCommand
    {

        public static Boolean CmdSearch(String[] cmd)
        {
            if (cmd[0].ToUpper() == "ECHO" )
            {
                echo(cmd);
                return true;
            } else if (cmd[0].ToUpper() == "VER")
            {
                printVersion();
                return true;
            }
            else if (cmd[0].ToUpper() == "CGS")
            {
                CGSTest.consoleTest();
                return true;
            }
            else if (cmd[0].ToUpper() == "CGS1")
            {
                ConsoleGraphics.fillBackground(ConsoleColor.Blue);
                ConsoleGraphics.drawBox(20,12,60,16,ConsoleColor.Gray);
                return true;
            }
            else
            {
                return false;
            }

           // return false;
        }


        public static void echo(String[] cmd)
        {
            String output = "";
            for(int i = 1; i < cmd.Length; i++)
            {
                output += cmd[i] + " "; //TODO: Improve this so that a space isn't left at the end
            }
            Console.WriteLine(output);
        }

        public static void printVersion()
        {
            Console.WriteLine(SystemInformation.getProduct());
            Console.WriteLine(SystemInformation.getLongName());
            Console.WriteLine(SystemInformation.getCopyright());
            Console.WriteLine("Version " + SystemInformation.getLongVersion());
        }
    }
}
