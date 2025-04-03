namespace Filhåndtering_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Software til at test gemme og læse fra en fil");

            //Vi instantierer en bil og en datahandler
            
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
            
            //Listen oprettes - uden en liste kan vi ikke gemme noget:
            List<Car> cars = new List<Car>();

            //Vi tilføjer bilen til listen. Det skal forstås sådan, at det enkelte objekt bliver sat på listen. 
            cars.Add(car);

            //Her kaldes datahandleren og vi gemmer listen i en fil. Gå over i datahandler klassen for mere forklaring.
            dataHandler.SaveToFile(dataHandler.filePath, cars); //Bemærk argumenterne; uden disse ville der blive kastet en fejl. 
            
            Console.ReadKey();
            Console.WriteLine("Tryk en tast og så læses listen");
            Console.ReadKey();
            Console.WriteLine("Indholdet i filen er:");

            //Metoden til at hente fra filen kaldes igen her. Bemærk at igen at vi sender filnavnet med som argument.
            dataHandler.ReadFromFile(dataHandler.filePath);
            
            Console.ReadLine();
        }
    }
}
