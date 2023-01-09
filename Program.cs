// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//test test test
//Console.WriteLine("test test test");

/* Author:
 * Date:
 * test test test
 */


// x is being declared
int x;

// x is being initialized
    x = 10;

//combined
int y = 5;

//constant
const double TAXRATE = 0.06;
//TAXRATE = 1; CANNOT CHANGE A CONSTANT


//example

Console.WriteLine("Please enter a radius");
//String result = Console.ReadLine();
//double num = double.Parse(result);
double num = double.Parse(Console.ReadLine());
double area = num * num * Math.PI;

Console.WriteLine(area);

//Null
string myName = null;
Console.WriteLine(myName);
string friend = "Connor";

if (friend == "Family")
{
    myName = "Jun";
}
else if (friend == "Connor")
{
    myName = "Percy";
}
Console.WriteLine(myName);