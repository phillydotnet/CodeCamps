// Collection Expressions
// - C# 12 introduces an enhanced way to initialize collections. More versatile
//   than an initializer, expressions generate more optimal and correct code. For
//   example, immutable collections. Initializers never worked with immutable 
//   collections.
//
//   Full Spec: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-12.0/collection-expressions

// The Problem With Immutable Collections Initializers
//using System.Collections.Immutable;

//// this:
//var x = new List<int>() { 1, 2, 3 };
//Console.WriteLine(string.Join(", ", x));

//// is just syntactical sugar for:
//var y = new List<int>();
//y.Add(1);
//y.Add(2);
//y.Add(3);
//Console.WriteLine(string.Join(", ", y));



//// doesn't work for immutable lists, since adding creates a new list
//var z = new ImmutableList<int>();        // creates an empty list
//z.Add(1);  // returns a list of [1]
//z.Add(2);  // returns a list of [2]
//z.Add(3);  // returns a list of [3]
//Console.WriteLine(string.Join(", ", z)); // writes an empty list

//// which is why creating an immutable list now looks like
//var zz = ImmutableList.Create(1, 2, 3);
//Console.WriteLine(string.Join(", ", zz));



// what if collections could control their initialization, instead
// of using the .Add() pattern?
//using System.Collections;
//using System.Collections.Immutable;
//using System.Runtime.CompilerServices;

//ImmutableList<int> a = [1, 2, 3];
//Console.WriteLine(string.Join(", ", a));

//ImmutableList<int> b = [..a, 4, 5];
//Console.WriteLine(string.Join(", ", b));

//int[] cArray = [1, 2, 3];
//Span<int> cSpan = [1, 2, 3];
//int[] cEmptyArray = [];

//// Collection Builders
//MyImmutableArray<int> customBuilder = [10, 20, 30];
//Console.WriteLine(string.Join(", ", customBuilder));

//[CollectionBuilder(typeof(MyImmutableArrayBuilder), "Create")]
//public struct MyImmutableArray<T> : IEnumerable<T>
//{
//    public T[] Items { get; }

//    public MyImmutableArray(ReadOnlySpan<T> items)
//    {
//        Items = items.ToArray();
//    }

//    public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)Items).GetEnumerator();
//    IEnumerator IEnumerable.GetEnumerator() => Items.GetEnumerator();
//}

//public static class MyImmutableArrayBuilder
//{
//    public static MyImmutableArray<T> Create<T>(ReadOnlySpan<T> items)
//    => new MyImmutableArray<T>(items);
//}