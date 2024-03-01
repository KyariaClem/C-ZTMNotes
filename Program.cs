// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

Console.WriteLine("Hello, World!");


/* 1. Create instance of DateTime class
        formart (DateTime variableName = new DateTime(year, month, day)
    2. Console.WriteLine(variableName.DayOfWeek)

*/
DateTime myBirthday = new DateTime(1999, 4, 20);
Console.WriteLine(myBirthday.DayOfWeek);


DateTime today = DateTime.Today;
DateTime now = DateTime.Now;
DateTime utc = DateTime.UtcNow;

//DateTime Parsing
// Use DateTime.Parse
// DateTime birthday = DateTime.Parse("20.04.1999");
// // using DateTime.Parse in us format month/day/year
// DateTime usBirthdayFormat = DateTime.Parse("04/20/1999", new CultureInfo("en-Us"));
// //print both formats to console
// Console.WriteLine($"local birthday formart :{birthday}, usDate : {usBirthdayFormat}");

//Ternary operator conditional
// [bool exprression] ? [true expression] : [false expression]
int numberPractice = 4;
string productVerison = numberPractice == 4 ? "4.0" : "3.0";
Console.WriteLine(productVerison);


// Class and Objects
/*Object format
-[Class Name] [Variabe Name] = new CLassName();
ex: Person personObject = new Person()
*/

/*
Class - outlines the blueprint
object - 
*/