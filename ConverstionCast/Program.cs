//Converstion using (CAST)


//int age = 24;

//double age2 = age;
////implicit conversion
//int dbAge = age;

//string ageStr = "18";

////explicit conversion (Cast) did not work have to use Convert
//int result = Convert.ToInt32(ageStr);

//Console.WriteLine(result);

////converstion using Class


#region Parse and TryParse

string number = "150xxx";

int.TryParse(number, out int num);


Console.WriteLine(num);
//int convertedNumber = int.Parse(number);

//Console.WriteLine(convertedNumber*1.5);

#endregion