// C# 13 introduces a new escape sequence \e for the ESCAPE character. Previously,
// you had to use the fixed length unicode escape sequence \u001b or the variable
// length unicode escape sequence \x1b, the latter being dangerous if the following
// characters are hexadecimal digits as they would became part of the escape sequence.

var someString = "\eHello World";
Console.WriteLine(someString);