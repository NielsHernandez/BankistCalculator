


#region Tables


// user input

Console.WriteLine("Enter start table: ");

int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter end table: ");

int secondNumber = int.Parse(Console.ReadLine());



for (int i = firstNumber; i <= secondNumber; i++)
{

    Console.WriteLine("Table : "+ i);

    for (int j = 1; j <= 10; j++) { 

        Console.WriteLine($" {i} X {j} = {i*j}");
        
    }

    Console.WriteLine();
}


#endregion