//index fixed length array

string[] days = new string[4];

days[0] = "M";
days[1] = "T";
days[2] = "W";
days[3] = "T";

for (int i = 0; i < days.Length; i++)
{
    Console.WriteLine(days[i]);
}


//curly braces array

string[] shoppingCart = new string[] {"Apple", "Banana"};

for (int i = 0;i < shoppingCart.Length; i++)
{
    Console.WriteLine(shoppingCart[i]);
}

// new version of array declaration similar to javascript ES6+

string[] task = ["home work", "practice", "test"];

foreach (string s in task)
{
    Console.WriteLine(s);
}