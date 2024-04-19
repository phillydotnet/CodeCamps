// Ref Readonly

// From The Docs: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/method-parameters
//                https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-12.0/ref-readonly-parameters

// Motivation:
// - C# 7.2 introduced 'in' parameters as a way to pass readonly references. 'in' parameters
//   allow both lvalues and rvalues and can be used without any annotation at the callsite.
//   However, APIs which capture or return references from their parameters would like to
//   disallow rvalues and also enforce some indication at the callsite that a reference is
//   being captured. 'ref readonly' parameters are ideal in such cases as they warn if used
//   with rvalues or without any annotation at the callsite.

// Use Case:
//  - Pass in a readonly reference to variables.
//  - Require the caller to annotate as an indication of pass by reference.

// Parameters In C# 12:
//          ref: the method can read or write the value of the argument
//               variables only
//               callsite annotation required (ref)

//          out: the method sets (write) the value of the argument
//               variables only
//               callsite annotation required (out)

//           in: the method reads, but can't write the value of the argument
//               variables or any expression
//               no annotation required (in or ref (with warning))

// ref readonly: the method reads, but can't write the value of the argument.
//               variables only (warning for non-variable expression)
//               callsite annotation recommended (ref or in)

// Non-Variable Expressions: constants, method return values, properties, ...

// Framework Examples:

// ReadOnlySpan<int>
// Accept readonly references even though passing rvalues to them doesn't really make sense:
// .NET 7: public ReadOnlySpan(in T reference)
// .NET 8: public ReadOnlySpan(ref readonly T reference)

// Unsafe
// Parameters to disallow rvalues even though they don't mutate the passed reference:
// .NET 7: public static bool IsNullRef<T>(ref T source)
// .NET 8: public static bool IsNullRef<T>(ref readonly T source)

// See docs for upgrade path compatibility:
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-12.0/ref-readonly-parameters