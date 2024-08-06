namespace Paraminter.Arguments.CSharp.Type.Models;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using Paraminter.Associators.Models;

/// <summary>Represents syntactic data about a C# type argument.</summary>
public interface ICSharpTypeArgumentData
    : IArgumentData
{
    /// <summary>The syntactic data about the C# type argument.</summary>
    public abstract TypeSyntax SyntacticArgument { get; }
}
