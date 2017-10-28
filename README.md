# InternalSharing

This is a sample project demonstrating how internal members defined in one assembly library can be shared with other assemblies in C# .NET.

This solution makes sense in following case:-

We want to make a methods/properties **public** for our assemblies 
but we do not want to make it public for 3rd party assemblies refrencing our assemblies.


## Summary

Simply add the following attribute in the namespace of the shared assembly

```csharp

[assembly: InternalsVisibleTo("<AssemblyNameHere>")]
[assembly: InternalsVisibleTo("<AnyOtherAssemblyNameHere>")]

```

For example :

```csharp

[assembly: InternalsVisibleTo("FriendAssembly")]
[assembly: InternalsVisibleTo("FriendAssembly.Utilities")]
namespace MainCore.Demo
{
    internal class InternalDemoInsideClass
    {
        internal static string myInternalStaticVariable = "10";
    }
}
```

## Making friends with signed assembly

```csharp

[assembly: InternalsVisibleTo("FriendAssembly, PublicKey=002400000480000094" + 
                                    "0000000602000000240000525341310004000" +
                                    "001000100bf8c25fcd44838d87e245ab35bf7" +
                                    "3ba2615707feea295709559b3de903fb95a93" +
                                    "3d2729967c3184a97d7b84c7547cd87e435b5" +
                                    "6bdf8621bcb62b59c00c88bd83aa62c4fcdd4" +
                                    "712da72eec2533dc00f8529c3a0bbb4103282" +
                                    "f0d894d5f34e9f0103c473dce9f4b457a5dee" +
                                    "fd8f920d8681ed6dfcb0a81e96bd9b176525a" +
                                    "26e0b3")]

[assembly: InternalsVisibleTo ("FriendAssembly, PublicKey=" + Constants.PublicKey)]


//Where Constants.PublicKey could be a constant in a static class called Constants

```

## References


[MSDN Reference](https://msdn.microsoft.com/en-us/library/system.runtime.compilerservices.internalsvisibletoattribute(v=vs.110).aspx)