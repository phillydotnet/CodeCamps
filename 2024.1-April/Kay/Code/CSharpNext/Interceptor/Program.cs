// Demo From https://github.com/dotnet/roslyn/blob/main/docs/features/interceptors.md

var c = new C();
c.InterceptableMethod(1); // prints "interceptor 1"
c.InterceptableMethod(1); // prints "other interceptor 1"
c.InterceptableMethod(2); // prints "other interceptor 2"
c.InterceptableMethod(1); // prints "interceptable 1"

class C
{
    public void InterceptableMethod(int param)
    {
        Console.WriteLine($"interceptable {param}");
    }
}