




Car mcQueen = new Car();
mcQueen.Brand = "Cars";
mcQueen.Model = "Spring";
mcQueen.releasedYear = 2024;

mcQueen.starVehicle();
mcQueen.Parked();
mcQueen.stopVehicle();


MotorCycle moto = new MotorCycle();
moto.Brand = "Italika";
moto.Model = "Navy";
moto.releasedYear = 2018;

moto.starVehicle();
moto.weelie();
moto.stopVehicle();


ElectricaCar carrito = new();


carrito.baterryCapacity = 90;
carrito.baterryLevel();



//Inheritance
//Access modifiers public can be access from parent class, child class and instances
// protected can be access from Own class and child class, no from instances / out side
// private can be access from Own class Self.

class Vihicle
{
    public string Brand { get; set; }

    public string Model { get; set; }

    public int releasedYear { get; set; }


    public void starVehicle()
    {
        //releasedYear = 2025;
        Console.WriteLine("vehicle started.");
    }

    public void stopVehicle()
    {
        Console.WriteLine("vehicle stopped.");
    }


}


class Car : Vihicle
{
    public int numOfDoors { get; set; }
    
    public void Parked()
    {
        //releasedYear = 200;
        Console.WriteLine("car Parked");
    }
}

class MotorCycle : Vihicle
{
   public void weelie()
    {
        Console.WriteLine("MotorCycle made a weelie");
    }
}


//level inheritance

class ElectricaCar : Car
{
    public int baterryCapacity { get; set; }

    public void baterryLevel()
    {
        Console.WriteLine("battery level: " + baterryCapacity);
    }

}