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
        int i = 0, j, count = 0;
        public static int ssl;
        public string substring, output;

        public char[] ms = new char[mainstring.Length];
        public char[] ss = new char[ssl];

        public string ReadSubstring()
        {
            Console.WriteLine("Enter Sub String");
             substring = Console.ReadLine();
            ssl = substring.Length;
            return substring;
        }
        public string Issubstring( string substring)
        {
            while (i < ms.Length)
            {
                
                 if (ss[0] == ms[i])
                    {

                        for (j = 1; j <ss.Length; j++)
                        {
                        i++;
                        if (ss[j] == ms[i])
                        {
                            count++;
                           
                        }
                        }
                    string output = (count == ssl) ? "is substring" : ";not substring";
                    
                    }
                    else
                    {
                        i++;
                    }
                
            }

            return output;
        }
    }
}
    























































































































       
   