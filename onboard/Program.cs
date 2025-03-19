// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int age = 18;


string name = Console.ReadLine();


Console.WriteLine(name);

int turnOn = 0;


while(turnOn == 0)
{
    Console.WriteLine("what do you like to do. 1 continue, 2  print name");
    string opt = Console.ReadLine();

    switch (opt)
    {
        case "1":

            break;
    case "2":
            Console.WriteLine("niels");
            break;
        default:

            Console.WriteLine("existing");
            turnOn = 1;
            break
                ;
    }
}


//Console.WriteLine(age + 1);
