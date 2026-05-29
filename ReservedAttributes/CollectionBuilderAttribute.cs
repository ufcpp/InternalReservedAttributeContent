namespace System.Runtime.CompilerServices
{
#if !NET8_0_OR_GREATER
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Struct, Inherited = false)]
    internal sealed class CollectionBuilderAttribute(Type builderType, string methodName) : Attribute
    {
        public Type BuilderType { get; } = builderType;
        public string MethodName { get; } = methodName;
    }
#endif
}
