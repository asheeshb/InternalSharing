using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendAssembly
{
    class FriendlyAssemblyProgram
    {
        static void Main(string[] args)
        {
            string isAvailableThoughInternal = MainCore.Demo.InternalDemoInsideClass.myInternalStaticVariable;
            string isAvailableThoughInternal_2 = MainCore.InternalDemoOuterClass.myInternalStaticVariable_of_OuterClass;

            string myStaticVariable = MainCore.PublicDemoClass.myPublicStaticVariable;
        }
    }
}
