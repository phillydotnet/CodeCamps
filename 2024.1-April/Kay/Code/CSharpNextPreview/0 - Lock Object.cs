// .NET 9 is introducing a new System.Threading.Lock type as a better alternative
// to existing monitor-based locking. The presence of the lock keyword in C# might
// lead developers to think they can use it with this new type. Doing so wouldn't
// lock according to the semantics of this type but would instead treat it as any
// other object and would use monitor-based locking.
//
// Spec: https://github.com/dotnet/csharplang/blob/main/proposals/lock-object.md
// Compiler PR: https://github.com/dotnet/roslyn/pull/72137/files#diff-d49e74b493afafa9a24231849fcaf7e5dd9cebef04826d75507fcf2aa65453f3
//
// This sample is adapted from the Roslyn Compiler tests.

// create .NET 9 lock
Lock _lock = new();

// works in C# 13 with the lock keyword (instead of locking on the object)
LockPattern();

Console.WriteLine();

// works in any C# version with the using keyword.
UsingPattern();


void LockPattern()
{
    Console.WriteLine("Lock Pattern");
    Console.WriteLine("- Before Lock");
    lock (_lock)
    {
        Console.WriteLine("- In Lock");
    }
    Console.WriteLine("- After Lock");
}

void UsingPattern()
{
    Console.WriteLine("Using Pattern");
    Console.WriteLine("- Before Lock");
    using (_lock.EnterScope())
    {
        Console.WriteLine("- In Lock");
    }
    Console.WriteLine("- After Lock");
}

// Simulate .Net 9 Lock Class. Feature is ONLY for this type.
namespace System.Threading
{
    public class Lock
    {
        public Scope EnterScope()
        {
            Console.WriteLine("- Enter Scope");
            return new Scope();
        }

        public ref struct Scope
        {
            public void Dispose()
            {
                Console.WriteLine("- Dispose");
            }
        }
    }
}

