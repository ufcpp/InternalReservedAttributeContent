#if !NET7_0_OR_GREATER
namespace System.Diagnostics.CodeAnalysis
{
    [AttributeUsageAttribute(
        AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Parameter,
        AllowMultiple = false,
        Inherited = false)]
    internal sealed class UnscopedRefAttribute : Attribute { }
}

namespace System.Runtime.CompilerServices
{
    [AttributeUsage(AttributeTargets.Module, AllowMultiple = false, Inherited = false)]
    internal sealed class RefSafetyRulesAttribute : Attribute
    {
        public readonly int Version;

        public RefSafetyRulesAttribute(int version)
        {
            Version = version;
        }
    }
}
#endif
