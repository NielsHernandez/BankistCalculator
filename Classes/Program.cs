



using System.Reflection;
using System.Xml.Linq;

Person person = new Person();
person.name = "niels";
person.age = 32;

person.printInfo();

Employee employee = new Employee();
employee.name = "nico";
employee.age = 32;
employee.company = "HXL";
employee.salary = 2000;

employee.printInfo();

//creating a car

Car carrito = new Car("Toyota", 2021);

carrito.printInfo();

public class Person
{
    //fields are different the properties

    public string name;
    public int age;

    public void printInfo()
    {
        Console.WriteLine($"Name: {name} Age: {age}");
    }

}


public class Employee : Person
{
    public string company;
    public int salary;

    public void printInfo()
    {
        Console.WriteLine($"Name: {name} Age: {age} Company: {company} Salary: {salary}");
    }
}


public class Car
{
    public string make;
    public int model;

    public Car(string make, int model)
    {
        this.make = make;
        this.model = model;
        
    }
    public void printInfo()
    {
        Console.WriteLine($"Maker: {make} Model Year: {model}");
    }

}