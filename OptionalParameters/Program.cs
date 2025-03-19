using System.Runtime.InteropServices;

namespace OptionalParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            program.optinalParameters(name: "niels", age:32);

            //with named parameter the code is more readible

            program.optinalParameters(age: 32, name: "niels");
        }

        public void optinalParameters(string name, int? age, string city="gt")
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(city);
        }
    }
}
