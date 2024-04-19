// C# 13 continues to improve "betterness", referring to the way the compiler infers
// the best method for a given set of arguments. C# 10 introduced a "weak natural type" 
// which comes into play with type inference, but has an edge case with extension
// methods with different signatures. The compiler considers both the methods of the class
// and the extension methods when inferring the type Now, methods of the class are considered
// first. This allows the compiler to infer types in more edge cases.
//
// See: https://github.com/dotnet/csharplang/issues/7364

//var instance = new C();
//var someObject = new object();

//// Delegate type Action will map to SomeClass.Foo:
//Action x = instance.M;
//Console.Write("x = ");
//x();

//// Delegate type Action<object> will map to SomeExtensionMethods.Foo:
////Action<object> y = instance.M;
////Console.Write("y = ");
////y(someObject);

//// C# would previously fail to infer the delegate type. With the new
//// rules, C# would prefer the instance / natural type. Reduces surprises
//// if changing "Action x = instance.Foo" to "var x = instance.Foo".
////var z = instance.M;
////Console.Write("z = ");
////z();


//public class C
//{
//    public void M() {
//        Console.WriteLine("Class Method");
//    }
//}

//public static class Extension
//{
//    public static void M(this C c, object o) {
//        Console.WriteLine("Extension Method");
//    }
//}