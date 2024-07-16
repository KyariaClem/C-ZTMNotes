// See https://aka.ms/new-console-template for more information
using System.Dynamic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

Console.WriteLine("Hello, World!");

var name1 = "kyaria";
Console.WriteLine(name1);

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
    define methods
    ex: string GetModel();

}

-Syntax to implent interfaces in classes:
public class class name : interface name
ex: public class TelsaModels : ICar {

}
*/

//Method overloading 
/*
- create twon constructors
0one basic constructor, then another construcrtor for other methods to use

*/


// inheritance
/*  
-inherit from base or parent class
-  in inheritance get everything BUT constructor
- only have access to public modifers

SYNTAX FOR INHERITENCE 
public class child class : parent class {
    create constructor
}

-VIRUTAL KEYWORD: virtual 
  - does what ?
        * allows you override methods, etc in parent class within the child class.
         - add the virutal keyword ib the parent class method, no keyword = no override / manipulation
*/

//AddingNewEventArgs NOTES

// Polymorphism

// Variable rules
/*
-Properties "Method getters/ setter names": Uppercase
-field: underscore_and_lowercase
-local variables: lowercase
*/
// string yesAnswer = "yes";
// string accountYesNoQuestion = Console.ReadLine();
// String noAnswer = "no";
// String accountNoQuestion = Console.ReadLine();
// if(accountYesNoQuestion == yesAnswer) {
//     Console.WriteLine("Awesome, you want to open a checking account how much do you want to deposit ?");
// //     string inputAccountDeposit = Console.ReadLine();
// // int accountDeposit = int.Parse(inputAccountDeposit);
// // string inputAccountDeposit = Console.ReadLine();
// //     Console.WriteLine("It worked !");
// } else if (accountNoQuestion == noAnswer) {
//     Console.WriteLine("Do you want to open a premium account ?");
// } else {
//     Console.WriteLine("Have a great day !");
// };

// Implicat typing
/*
- can use var keyword
ex:
instead of Person Person1 = new Person();

do:
var Person1 = new Person();

- can also use var for variable types that are obvious 
-can be used to create local variable only
- complier replaces var keyword with the actua variable type during compliation
ex One:
string name = "Kyaria"
do:
var name = "Kyaria (complier knows the tyoe is string)

ex Twp:
int age = 25;
do:
var age = 25;
*/

//var name2 = "kyaria";

// COnst
/* 
- Use CONST keyword to keep variable from changing
*/

//garage collection
/* 
2 Types
    1. Stack: 
        - Array of memory. data can only be added and deleted from the top
        1 -> 2 -> 3 -> 3 -> 4




    2. heap: area of memory where chunks are allocated to store objects
        How to access ?
                - reference points

            
*/

// Enumrations / Enurmation types
/* 
enumartions: a set name on constant vales attached
enumator list: list of values
Structure:
        (enum keyword) (enum names ) {
            values
        }
    Stucture Ex:
            enum TemperatureUnit {
                Celcius,
                Fahrenhit
            }

    // Create class called Temperature:
    class Temperature {

        // create 
        public Temperature(TempertureUnit Unit , decimal Value)

    // create getter and setters
        // Get setter for enum TemperatureUnit name of unit
        public TempertaureUnit Unit {get; set; }

        // Get setter for value ( so we can pass in a value for the temp class when we create an instance of the class)
         public decimal Value {get ; set ;}
    }

*/

// SWITCH STATEMENTS
/* 

return VARIABLE NAME switch 
{
EXPRESSION =>(arrow opertor) 

}

*/

// STRUCTS
/* 
WHAT ?
- A structure type, a value type that encapsulates data and functionality
- Almost same format/ set up as class BUT instead of class keyword, use struct keyword
EX:
Setting instance of struct (mimics that of setting instance of class): 
var rectangle = new Rentangle(200; 300)
public struct Rectangle {

    public Rectangle(double width, double height) 
    {
        Width = width;
        Height = height;
    }

public double Width{get; set;}
public double Height{get; set;}
}
*/