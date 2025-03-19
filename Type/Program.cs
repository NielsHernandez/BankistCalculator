//boelan types

bool isCompleted = default;

Console.WriteLine(isCompleted);
isCompleted = true;

Console.WriteLine(isCompleted);


//Integral types or Int

byte edad = 18;

int payment = 10500;

double superNumber = 5.55555;

float superFloat = 1.999999999f;


//String type and skip character like ////


string multiLine = """"
    this is a test
    xd
    testing
    """";

Console.WriteLine(multiLine);

//Value types by reference types

int x = 10;

int y = x;

x = 15;

Console.WriteLine($"{x} - {y}");


string person = "niels hernandez";

string person2 = person;

person = "Jacob";

Console.WriteLine($"person: {person} person1: {person2}");