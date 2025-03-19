//POLYMORPHISM WITH METHOD OVERRADING 


Person p1 = new Person()
{ name = "jose", lang = "ES" };

Person p2 = new American() { name = "Jon", lang = "EN" };
Person p3 = new German() { name = "Tony", lang = "GER" };
Person p4 = new Brazilian() { name = "Gustovo", lang = "BR" };





p1.Salutate();
p2.Salutate();
p3.Salutate();
p4.Salutate();



class Person
{
    public string name { get; set; }
    public string lang { get; set; }

    public virtual void Salutate()
    {

        Console.WriteLine($"Hola soy  {name} {lang}");
    }
}



class American : Person
{
    public override void Salutate()
    {

        Console.WriteLine($"Hello I am {name} {lang}");
    }

}

class German : Person
{
    public override void Salutate()
    {

        Console.WriteLine($"Salut Her {name} {lang}");
    }

}

class Brazilian : Person
{
    public override void Salutate()
    {

        Console.WriteLine($"Hi Voce mi {name} {lang}");
    }

}