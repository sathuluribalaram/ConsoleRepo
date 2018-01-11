using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonFunctions;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonFunctions.Log.Debug("Entered Main method.");

            CommonFunctions.Log.Error();
            //Log LogObj = new Log();
            //LogObj.Debug("Entered Main method.");
            //LogObj.Error();

            //LogObj.Debug("Exit from Main method.");

            Console.ReadLine();
        }
    }
}
