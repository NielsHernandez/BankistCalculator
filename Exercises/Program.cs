
#region class usage

Circle circle = new Circle(2);
circle.printAre();

Circle.Pi = 4;


circle.printAre();

Circle circle1 = new Circle(3);
circle1.printAre();





#endregion




#region class definition
//most of the code bellow are instance member fields and methods

public class Circle
{
    public static float Pi = 3.162F;
    public int radious;

    public Circle(int radious)
    {
        this.radious = radious;

    }

    public void printAre()
    {
        Console.WriteLine($"the are of the circle is: {Pi * radious * radious}");
    }
}

#endregion