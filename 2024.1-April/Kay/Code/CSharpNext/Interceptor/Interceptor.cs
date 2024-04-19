using System.Runtime.CompilerServices;

namespace Test
{
    // generated code
    static class D
    {
        [InterceptsLocation(@"C:\Users\Scott\Desktop\CSharpNext\Interceptor\Program.cs", line: 4, character: 3)]
        public static void InterceptorMethod(this C c, int param)
        {
            Console.WriteLine($"interceptor {param}");
            c.InterceptableMethod(param);
        }

        [InterceptsLocation(@"C:\Users\Scott\Desktop\CSharpNext\Interceptor\Program.cs", line: 5, character: 3)]
        [InterceptsLocation(@"C:\Users\Scott\Desktop\CSharpNext\Interceptor\Program.cs", line: 6, character: 3)]
        public static void OtherInterceptorMethod(this C c, int param)
        {
            Console.WriteLine($"other interceptor {param}");
        }
    }
}

namespace System.Runtime.CompilerServices
{
    // doesn't exist yet in .NET 8. let's pretend it does.
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
#pragma warning disable CS9113 // Parameter is unread.
    public sealed class InterceptsLocationAttribute(string filePath, int line, int character) : Attribute
#pragma warning restore CS9113 // Parameter is unread.
    {
    }
}