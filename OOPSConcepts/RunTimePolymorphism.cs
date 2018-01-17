using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    class RunTimePolymorphism: CompileTimePolymorphism
    {
        public RunTimePolymorphism(int parametre):base(parametre)
        {
            //base.a = 20;
        }
        //public override int Add(int a, int b)
        //{

        //    int sum = 10+a + b ;
        //    return sum;
        //}

        public new int Add(int a, int b)
        {
            int sum = 20+ a + b;
            return sum;

        }
        //public float Add(float a, float b)
        //{
        //    float sum = a + b;
        //    return sum;

        //}
    }
}
