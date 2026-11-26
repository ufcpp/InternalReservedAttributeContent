#if !NET11_0_OR_GREATER
#nullable enable

namespace System.Runtime.CompilerServices;

internal interface IUnion
{
    object? Value { get; }
}

#endif
