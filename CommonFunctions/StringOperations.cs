using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctions
{
    public class StringOperations
    {
        public string ReadSubstring()
        {
            Console.WriteLine("Enter Sub String");
            string substring = Console.ReadLine();
            return substring;
        }
        public string Issubstring(string mainstring, string substring)
        {
            char[] ms = mainstring.ToCharArray();
            char[] ss = substring.ToCharArray();
            int i = 0, count, j;
            string output = "not found";

            while (i < ms.Length)
            {
                count = 0;

                if (ss[0] == ms[i])
                {

                    for (j = 0; j < ss.Length; j++)
                    {

                        if (ss[j] == ms[i])
                        {
                            count++;
                            i++;

                        }
                    }
                    if (count == ss.Length)
                    {
                        output = "string found";
                        return output;
                    }

                }
                else
                {
                    i++;
                }


            }

            return output;
        }

        public string ReverseString(string substring)
        {

            char temp;
            char[] mainstring = substring.ToCharArray();
            int j = mainstring.Length - 1;
            for (int i = 0; i < mainstring.Length / 2; i++)
            {
                temp = mainstring[i];
                mainstring[i] = mainstring[j];
                mainstring[j] = temp;
                j--;
            }

            string reverse = new string(mainstring);
            return reverse;
        }
    }
}

























































































































