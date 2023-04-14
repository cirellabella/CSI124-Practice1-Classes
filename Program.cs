namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Honda", "Civic", 2010, "Purple", 50000);

            Console.WriteLine(car.ToString());

            Bike bike = new Bike("Huffy", "Green", 2);

            Console.WriteLine(bike.ToString());

            Yoga yoga = new Yoga("Purple", 2, 1, "Yoga with Adriene");

            Console.WriteLine(yoga.ToString());


        }
    }
}