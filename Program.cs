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
    myName = "Jun Kim";
}
else if (friend == "Connor")
{
    myName = "Percy";
}
Console.WriteLine(myName);

//Exercise 1

Console.WriteLine("Please enter some text");
string someText = Console.ReadLine();
Console.WriteLine(someText);

//Exercise 2

Console.WriteLine("Enter a number");
int userNum = int.Parse(Console.ReadLine());
userNum += 1;
Console.WriteLine(userNum);

//Exercise 3

Console.WriteLine("Enter a number");
double x3Num = double.Parse(Console.ReadLine());
x3Num += .5;
Console.WriteLine(x3Num);

//Exercise 4

Console.WriteLine("Enter number 1");
double x4Num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number 2");
double x4Num2 = double.Parse(Console.ReadLine());
double x4Sum = x4Num1+ x4Num2;
Console.WriteLine("The sum is " +x4Sum);

//Exercise 5

Console.WriteLine("Enter the first number");
double x5Num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
double x5Num2 = double.Parse(Console.ReadLine());
double x5Product = x5Num1 * x5Num2;
Console.WriteLine("The product is " + x5Product);