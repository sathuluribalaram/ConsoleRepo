using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    class CompileTimePolymorphism
    {
        public int a;
        public CompileTimePolymorphism(int param1)
        {
            a = param1;
        }
        public  int Add(int a,int b)
        {
            int sum = a + b;
            return sum;
        }
       
    }
}
