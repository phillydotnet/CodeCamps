// Inline Arrays
// - C# 12 includes a performance focused feature to treat an annotated struct
//   as a fixed size array, providing a safe alternative to unsafe fixed arrays.

//using System.Runtime.CompilerServices;
//using System.Runtime.InteropServices;

//var buffer = new Buffer().AsSpan();

//// populate
//for (int i = 0; i < 10; i++) {
//    buffer[i] = i;
//}

//// access
//foreach (var i in buffer) {
//    Console.WriteLine(i);
//}

//[InlineArray(10)]
//public struct Buffer
//{
//    private int _element0;

//    public Span<int> AsSpan()
//    => MemoryMarshal.CreateSpan(ref _element0, 10);
//}