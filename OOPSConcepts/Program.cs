using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    class Program
    {
        static void Main(string[] args)
        {

            CompileTimePolymorphism compileTimePolymorphismObj = new RunTimePolymorphism(10);
           
            

            Console.WriteLine("Output of Add Method is" + (compileTimePolymorphismObj.Add(10, 10)));

            RunTimePolymorphism runTimePolymorphismObj = new RunTimePolymorphism(10);
            Console.WriteLine("Output of Add Method is" + (runTimePolymorphismObj.Add(10, 10)));


            Console.ReadLine();
        }
    }
}
