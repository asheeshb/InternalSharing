using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendAssembly.Utilities
{
    public class FriendAssemblyUtility
    {
        public void SomeFunction()
        {
            string isAvailableThoughInternal = MainCore.Demo.InternalDemoInsideClass.myInternalStaticVariable;
            string isAvailableThoughInternal_2 = MainCore.InternalDemoOuterClass.myInternalStaticVariable_of_OuterClass;

            string myStaticVariable = MainCore.PublicDemoClass.myPublicStaticVariable;
        }
    }
}
