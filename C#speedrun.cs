// void SayHello(string name) {
//     Console.WriteLine("Hello, " + name);
// }

// SayHello("Athithyan");

// static void SayHello(string name) {
//     Console.WriteLine("Hello, " + name);
// }

// SayHello("Athithyan");

// Single line comment
/*
MURTL
*/

// string hello = "Hello";
// var name = "Athithyan";
// Console.WriteLine(hello + " " + name);

// Implicit typing
// var number = 10;

// string a = "Hello";
// int b = 10;
// double c = 10.5;
// float d = 10.5555f;
// bool e = true;
// DateTime f = DateTime.UtcNow; // UtcNow

// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(c);
// Console.WriteLine(d);
// Console.WriteLine(e);
// Console.WriteLine(f);

// var movie = new Movie("The Dark Knight", "Christopher Nolan", 2008);
// Console.WriteLine(movie);
// movie.Title = "The Dark Knight Rises";
// Immutable

// record Movie(string Title, string Director, int Year);
// output looks nice bruh - Movie { Title = The Dark Knight, Director = Christopher Nolan, Year = 2008 }

// var movie = new Movie{
//     Title = "The Dark Knight",
//     Director = "Christopher Nolan",
//     Year = 2008
// };
// Console.WriteLine(movie);
// struct Movie {
//     public string Title { get; set; }
//     public string Director { get; set; }
//     public int Year { get; set; }

//     public override readonly string ToString() {
//         return $"{Title} - {Director} - {Year}";
//     }
// }

// var movie = new Movie{
//     Title = "The Dark Knight",
//     Director = "Christopher Nolan",
//     Year = 2008
// };
// Console.WriteLine(movie);

// class Movie {
//     public required string Title { get; set; }
//     public required string Director { get; set; }
//     public required int Year { get; set; }

//     public override string ToString() {
//         return $"{Title} - {Director} - {Year}";
//     }
// }

// Modifier      Description                                                                 Accessibility
// public        The type or member is accessible by any other code in the same assembly      🌐 Anywhere
//               or another assembly that references it. This is the least restrictive
//               access level.
// private       The type or member is only accessible within the same class or struct        🔒 Within the declaring class only
//               in which it's declared. This is the most restrictive access level.
// protected     The type or member is accessible within its own class and by derived         🛡️ Within the declaring class and derived classes
//               classes (classes that inherit from it).
// internal      The type or member is accessible by any code in the same assembly,           📦 Within the same assembly only
//               but not from another assembly.
// file          (C# 11 and later) The type is visible only within the same source file.      📄 Within the same source file only
//               This is useful for creating types that are only used to help implement
//               a class or method within that specific file, preventing them from being
//               exposed externally.

// var movie1 = new Movie{
//     Title = "The Dark Knight",
//     Director = "Christopher Nolan",
//     Year = 2008
// };
// Console.WriteLine(movie1 + " " + (movie1.IsGood() ? "is good" : "is bad"));
// var movie2 = new Movie{
//     Title = "The Dark Knight Rises",
//     Director = "Christopher Nolan",
//     Year = 1991
// };
// Console.WriteLine(movie2 + " " + (movie2.IsGood() ? "is good" : "is bad"));

// interface IMovie
// {
//     string Title { get; set; }
//     string Director { get; set; }
//     int Year { get; set; }
//     bool IsGood();
// }

// public class Movie : IMovie
// {
//     public required string Title { get; set; }
//     public required string Director { get; set; }
//     public required int Year { get; set; }
//     public override string ToString()
//     {
//         return $"{Title} - {Director} - {Year}";
//     }

//     public bool IsGood() {
//         return Year > 2000;
//     }
// }

// var me = new Me();
// Console.WriteLine(me.Name);

// public class Me {
// // Readonly property
//     public string Name => "Athithyan";
// }


// This can be used to deconstruct the object
// public void Deconstruct(out string valueA) {}
// var (valueA) = me;
// same for record types


// if (Random.Shared.Next(0, 10) < 5) {
//     Console.WriteLine("< 5");
// } else {
//     Console.WriteLine(">= 5");
// }

// var num = Random.Shared.Next(0, 10);
// switch (num)
// {
//     case < 5:
//         Console.WriteLine("< 5");
//         break;
//     case >= 5:
//         Console.WriteLine(">= 5");
//         break;
//     default:
//         Console.WriteLine("default");
//         break;
// };

// string Switcher() => Random.Shared.Next(0, 10) switch {
//     < 5 => "< 5",
//     >= 5 => ">= 5",
// };

// Console.WriteLine(Switcher());

// for (var i = 0; i < 10; i++) {
//     Console.WriteLine(i);
// }

// foreach (var i in Enumerable.Range(0, 10)) {
//     Console.WriteLine(i);
// }

// Enumerable.Range(0, 100)
//     .Select(i => i * i)
//     .ToList()
//     .ForEach(Console.WriteLine);

// var stringArr = new string[] {"Hello", "World", "C#"};
// stringArr.ToList().ForEach(Console.WriteLine);

// var myList = new List<int> { 11, 12, 13, 14, 15 };
// myList.Select((value, index) => $"{index} - {value}").ToList().ForEach(Console.WriteLine);

// var myDict = new Dictionary<string, int>
// {
//     { "a", 1 }
// };
// foreach(var item in myDict) {
//     Console.WriteLine(item.Key + " - " + item.Value);
// }

// static IEnumerable<int> Infinite() {
//     var i = 1;
//     while (true) {
//         yield return i++;
//     }
// }

// foreach (var i in Infinite()) {
//     Console.WriteLine(i);
//     if (i >= 10) {
//         break;
//     }
// }

// var arr = new int[] { 1, 2, 3, 4, 5 };
// var sum = arr.Select(i => i * i).Aggregate(0, (a, b) => a + b);
// Console.WriteLine(sum);

// static async Task MyAsyncFunc() {
//     var quote = "I got room in my fumes";
//     foreach (var word in quote.Split(" ")) {
//         await Task.Delay(500);
//         Console.WriteLine(word);
//     }
// }

// await MyAsyncFunc();

// Use DI for the obvious advantages
// Service lifetimes
// Transient - new instance every time
// Scoped - new instance per request
// Singleton - one instance for the entire application
