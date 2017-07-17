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
    }
}
