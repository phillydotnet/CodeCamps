// C# 13 allows the "from the end" index operator in object initializer expressions.
// This is an oversight from the C# 10 "Ranges" feature.

//var v = new C()
//{
//    Buffer = {
//        [^1] = 1,
//        [^2] = 2,
//        [^3] = 3,
//    }
//};
//Console.WriteLine(string.Join(", ", v.Buffer));

//public class C
//{
//    public int[] Buffer = new int[3];
//}