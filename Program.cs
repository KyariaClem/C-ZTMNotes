// See https://aka.ms/new-console-template for more information
using System.Dynamic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
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
class Person 
{
    //fields , camcelCase with _ prefix
    private string _name;

    // constructor
    // use ctor to generate constuctor in VS as shortcut
   public Person()
   {
    _name = "kyaria";
   }

   // propertities , getters / setters
 /* 
 -Setters - allow value to be set outside the class
 -Getters - Allows accesss to the value outside the class
 */

 public string Name 
 {
    get {return _name; }
    set {_name = value; }
 }
}

//ShortPerson person = new ShortPerson("kyaria");
// Short verison for class writing
class ShortPerson
{
    // No fields
    // constructor
    // set field value in constuctor parameter
    public ShortPerson(string name)
    {
        // set field name in constructor 
        Name = name;
    }

public string Name {get; set;}


public void PrintGreeeting(){
    Console.WriteLine($"Hello + {Name}!");
}
}



// Value and Reference Types
/*
Value types ext int
in value types can create variables to refernce another variable
ex: int age = 24
    int age1 = age; references to age whiche equals 24
*/

/*
Referance types key words:
1. class
2. interface
3.delegate
4. record
*/

/*Name Spaces 
- NameSpaces group classes together
*/

// static
/*
- Cannot create instances of static classes
- static class can only contain static methods / proerties
-Use class name of static methods to access bec   ause they are not tied to an instance of a class.
*/

// interface 
/*
- use public access modifer, interface keyword, interface name
-use Pascal case for interface name
- start interface name with captial I
ex: public interface IKyaria {
    
}
*/