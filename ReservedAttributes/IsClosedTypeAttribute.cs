#if !NET11_0_OR_GREATER

using System.ComponentModel;

namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
[EditorBrowsable(EditorBrowsableState.Never)]
internal sealed class IsClosedTypeAttribute : Attribute
{
    public Type[] DerivedTypes { get; set; } = [];
}

#endif
