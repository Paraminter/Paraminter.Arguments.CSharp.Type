namespace Paraminter.Arguments.CSharp.Type.Models;

using Microsoft.CodeAnalysis.CSharp.Syntax;

/// <summary>Represents syntactic data about a C# type argument.</summary>
public interface ICSharpTypeArgumentData
{
    /// <summary>The syntactic data about the C# type argument.</summary>
    public abstract TypeSyntax Argument { get; }
}
