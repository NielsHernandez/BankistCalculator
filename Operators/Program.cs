//Assignment Operator =


string name = "my name is";

int number = 0;


//Arithmetic Operatos + - * / % ++ --

int a, b;

a = 0;
b = 0;

a++;
b++;

a++;

Console.WriteLine(a+b*a-b);
Console.WriteLine(b+a);

//Comparison Operatos == != > < >= <=

var result = a == 0;

Console.WriteLine(result);

var result2 = a != b;

Console.WriteLine(result2);

//Logical Operators && ||


Console.WriteLine(true && false);
Console.WriteLine(true && true);
Console.WriteLine(true || false);

//Ternary Operator ?

var para = "<p>hello</p>";
var title = "<h1>Title</h1>";


if("p" == "p")
{
    Console.WriteLine(para);
}

Console.WriteLine(false ? para:title);

//Null Coalescing Operator ??

string ?response  = null;

Console.WriteLine(response);