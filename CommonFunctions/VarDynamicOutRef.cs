using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctions
{
    public class VarDynamicOutRef
    {

        public void Varusage()
        {
            Console.WriteLine("Enter a value");
            var value =int.Parse(Console.ReadLine());
            Console.WriteLine("value is of type" + value.GetType());
        }
        public void DynamicUsage()
        {
            dynamic name = 123;
            string namestring=name.ToString();
            Console.WriteLine(namestring);
        }
        public void Add(ref int a, int b)
        {
            a = a + b;
            Console.WriteLine("value of a after executing method" + a);
        }
        public void Add(ref int a, int b, out int total, out int product)
        {
            Console.WriteLine("value of a is" + a);
            total = a + b;
            product = a * b;

        }
    }
}
