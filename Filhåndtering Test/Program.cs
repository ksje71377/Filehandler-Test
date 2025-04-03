namespace Filhåndtering_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Software til at test gemme og læse fra en fil");
            Car car = new Car();
            DataHandler dataHandler = new DataHandler();
            Console.WriteLine("Tast mærke:");
            car.Make = Console.ReadLine();
            Console.WriteLine("Tast model:");
            car.Model = Console.ReadLine();
            Console.WriteLine("Tast årgang:");
            car.Year = int.Parse(Console.ReadLine());
            Console.WriteLine("Tast farve:");
            car.Color = Console.ReadLine();
            Console.WriteLine("Tryk en tast og så oprettes listen");
            Console.ReadKey();
            List<Car> cars = new List<Car>();
            cars.Add(car);
            dataHandler.SaveToFile("cars.txt", cars);
            Console.ReadKey();
        }
    }
}
