namespace MyMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();

            Console.WriteLine(getYear());

            program.printDayName();

            Console.WriteLine(Program.areOfRectangle(10,10));

            string name = "niels";


            Console.WriteLine(name);

            program.printName(ref name);

            Console.WriteLine(name);

            program.printFullName(out string name1, out string lastName2);

            Console.WriteLine($"{name1} {lastName2}");
        }

        public static int getYear()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear;

        }

        public void printDayName()
        {
            Console.WriteLine(DateTime.Now.Day);
        }

        //method by value

        public static int areOfRectangle(int width, int heigh)
        {

            return width * heigh;

        }

        //method by reference remember to use the 'ref' key word

        public void printName(ref string name)
        {
            name = "Tom";
        }

        //method with in out parameters

        public void printFullName(out string name, out string lastName)
        {
            name = "Peter";
            lastName = "Jose";

        }

        
    }
}
