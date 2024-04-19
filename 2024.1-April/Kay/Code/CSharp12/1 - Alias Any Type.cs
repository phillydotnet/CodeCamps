// Alias Any Type

// C# 11 allows you to alias namespaces:
//using Sys = System;
//Sys.Console.WriteLine("Hello Philly.Net");

// C# 11 also allows you to alias types.
//using T = System.Collections.Generic.List<(int, int)>;
//var list = new T() { (1, 1), (2, 2) };

// C# 12 now allows you to alias more types, such unsafe types and tuples.
//using unsafe UnsafeArray = int*[];

//using Point = (int X, int Y);
//var p1 = (1, 2);
//ShowPoint(p1);

//void ShowPoint(Point p) => Console.WriteLine($"x: {p.X} y: {p.Y}");
