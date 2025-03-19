

#region String Length and Subtring

//string fullName = "Niels Manfredo Hernandez Flores";


//int countOfCharacters = fullName.Length;

//subtring

//string takenCharacters = fullName.Substring(0,fullName.IndexOf("s")+1);

//string takenCharacters = fullName.Substring(0, fullName.LastIndexOf("s") + 1);


//Console.WriteLine(takenCharacters);

#endregion


#region String Upper and Lower case + replace


//string email = "niels.Hernande Flores@gmail.com";

//string standarEmailCase = email.ToLower().Replace("niels","niels".ToUpper());


//Console.WriteLine(standarEmailCase);

#endregion


#region Split method

//string[] wordsInName = email.Split('.', 10, StringSplitOptions.TrimEntries);

//foreach (string word in wordsInName)
//{
//    Console.WriteLine(word);
//}


#endregion

#region Trim TrimStart TringEnd, StartsWith, EndsWith, Contains


string txt = " xxx nico williams xd @ test this is anoyying xd  ";

string? trimString = txt.Trim('x', ' ');

string trinStrExmaple = txt.Trim('x').Trim();

Console.WriteLine(trinStrExmaple);

string searchable = "this is a big string and it contains a lot of important information. so let's get started.";


bool result = searchable.StartsWith("this is");
bool resultEnd = searchable.EndsWith("started.");

Console.WriteLine(result ? "text found":"text not found");
Console.WriteLine(resultEnd ? "text found" : "text not found");

//contains

if (searchable.Contains("information"))
{
    Console.WriteLine(true);
}

#endregion

//printYear();

//static void printYear()
//{
//    Console.WriteLine(DateTime.Now.Year);
//}