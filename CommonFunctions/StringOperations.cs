using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctions
{
    public class StringOperations
    {
        static string mainstring = "komala";

        int position = 0;
        int i = 0, j, count = 0;
        public static int ssl;
        public string substring;

        public char[] ms = new char[mainstring.Length];
        public char[] ss = new char[ssl];

        public string ReadSubstring()
        {
            Console.WriteLine("Enter Sub String");
             substring = Console.ReadLine();
            ssl = substring.Length;
            return substring;
        }
        public int Issubstring( string substring)
        {
            while (i < ms.Length)
            {
                for (j = 0; j < ss.Length; j++)
                {
                    if (ss[j] == ms[i])
                    {
                        count++;
                        i++;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            return count;
        }
    }
}
    























































































































       
   