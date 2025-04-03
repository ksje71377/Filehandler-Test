using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filhåndtering_Test
{
    public class DataHandler
    {
        public string filePath = "cars.txt";

        public void CreateList()
        {
            List<Car> cars = new List<Car>();
        }
        public void SaveToFile(string filePath, List<Car> cars)
        {
            // Write the car data to the file
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (Car car in cars)
                {
                    writer.WriteLine($"{car.Make},{car.Model},{car.Year},{car.Color}");
                }
                writer.Close();
            }
        }
        public void ReadFromFile(string filePath)
        {
            // Read the car data from the file
            List<Car> cars = new List<Car>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    Car car = new Car
                    {
                        Make = parts[0],
                        Model = parts[1],
                        Year = int.Parse(parts[2]),
                        Color = parts[3]
                    };
                    cars.Add(car);
                }
                reader.Close();
            }
            // Print the car data to the console
            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
           
        }
    }
}
