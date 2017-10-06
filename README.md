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