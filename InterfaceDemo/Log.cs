using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Log : ILog
    {

        public void Error()
        {
            Console.WriteLine("Error Occured");
        }

        public void Debug(string debugMessage)
        {
            Console.WriteLine(debugMessage);
        }
    }
}
