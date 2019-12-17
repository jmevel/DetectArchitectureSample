# Detect Architecture Sample in .NET Core

Sample showing how to detect the architecture the program has been compiled for.

In that way we could do something like this

```csharp
#if Is64Bit
    [DllImport(@"Resources/HIDAPI/x64/hidapi")]
#else
    [DllImport(@"Resources/HIDAPI/x32/hidapi")]
#endif
```
