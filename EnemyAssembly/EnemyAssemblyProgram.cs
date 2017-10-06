using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainCore;

namespace EnemyAssembly
{
    class EnemyAssemblyProgram
    {
        static void Main(string[] args)
        {
            //These two lines will throw compiler error
            //string isAvailableThoughInternal = MainCore.Demo.InternalDemoInsideClass.myInternalStaticVariable;
            //string isAvailableThoughInternal_2 = MainCore.InternalDemoOuterClass.myInternalStaticVariable_of_OuterClass;

            string myStaticVariable = MainCore.PublicDemoClass.myPublicStaticVariable;
        }
    }
}
