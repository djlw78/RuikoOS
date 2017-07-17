using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuikoOS
{
    class SystemInformation
    {

        private static readonly String shortVersion = "1.0";
        private static readonly String longVersion = "1.0.11";
        private static readonly String productName = "RuikoOS";
        private static readonly String longName = "Ruiko Operating System";
        private static readonly String copyright = "(c) 2017 C.S. Media";

        public static String getShortVersion() { return shortVersion; }

        public static String getLongVersion() { return longVersion; }

        public static String getProduct() { return productName; }

        public static String getLongName() { return longName; }

        public static String getCopyright() { return copyright; }

    }
}
