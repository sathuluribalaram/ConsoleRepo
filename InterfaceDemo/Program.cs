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
            //CommonFunctions.Log.Debug("Entered Main method.");

            //CommonFunctions.Log.Error();
            //Log LogObj = new Log();
            //LogObj.Debug("Entered Main method.");
            //LogObj.Error();

            //LogObj.Debug("Exit from Main method.");
            Sorting sortingObj = new Sorting();
            sortingObj.ReadConsoleData();
            Console.WriteLine("Max Element of given Array is " + sortingObj.MaxelementofArray());
            int[] descendingorder = sortingObj.SortingArray();
            for (int i = 0; i < descendingorder.Length; i++)
            {

                Console.WriteLine("Array in descending order " + descendingorder[i]);
            }

            Console.ReadLine();
        }
    }
}
