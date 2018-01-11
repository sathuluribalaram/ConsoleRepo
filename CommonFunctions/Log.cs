using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctions
{
    public class Log
    {
        public static void Error()
        {
            Console.WriteLine("Error Occured");
        }

        public static void Debug(string debugMessage)
        {
            Console.WriteLine(debugMessage);
        }
    }
}
