using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("FriendAssembly")]
[assembly: InternalsVisibleTo("FriendAssembly.Utilities")]
namespace MainCore.Demo
{
    internal class InternalDemoInsideClass
    {
        internal static string myInternalStaticVariable = "10";
    }
}
