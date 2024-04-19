// Primary Constructors
// - C# 12 introduces primary constructors for classes and structs,
//   not just records. Use cases include dependency injection and
//   keeping private state (not exposed in properties).
//  
// Recommended Reading:
// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/primary-constructors

//var clippy = new Attendee(name: "Clippy", company: "Microsoft");
//Console.WriteLine(clippy.NameTag());

//var joeSmith = new Attendee(firstName: "Joe", lastName: "Smith", company: "Foo");
//Console.WriteLine(joeSmith.NameTag());

//public class Attendee(string name, string company)
//{
//    // NOTE: There is no auto property generation, unlike records. Best practice
//    //       is to use all lowercase name.

//    // Other constructors are still allowed, but must call the primary constructor.
//    public Attendee(string firstName, string lastName, string company)
//        : this(firstName + " " + lastName, company)
//    { }

//    // Optionally expose as properties, or reference directly anywhere within the
//    // scope of the class.
//    public string Name { get; set; } = name;
//    public string Company { get; set; } = company;

//    public string NameTag()
//    => Name + " from " + Company;
//}