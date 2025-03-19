//declare variables


using System.Runtime.CompilerServices;

string[] options = ["Add","Search","Update","Delete"];

string name = string.Empty;
int age = 0;

// pront user to enter a value

print("----Enter your name----");
name = Console.ReadLine();

// promt user to enter age
Console.WriteLine("----Enter your Age----");
try
{

	age = int.Parse(Console.ReadLine());
}
catch (Exception e)
{
    Console.WriteLine("enter a valid number");
    Console.WriteLine(e.Message);
    //throw;
    return;
}

Console.WriteLine("chose an operation");

foreach(string item in options)
{
    Console.WriteLine(item);
}

// confirm age

if (age <= 18)
{
    print($"age entered is not allow {age}");
}

print($"inputed information name: {name} age: {age}");



//DRY

void print(string? text)
{
    Console.WriteLine(text);
}