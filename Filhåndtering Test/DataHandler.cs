using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filhåndtering_Test
{
    internal class DataHandler
    {
        const string filePath = "cars.txt";
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
            }
        }
    }
}
