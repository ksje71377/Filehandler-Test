using Filhåndtering_Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]
namespace Filhåndtering_Test.Tests
{
    [TestClass]
    public class DataHandlerTests
    {
        // TODO: Create a test file path and a list of test cars to use in your tests
        private readonly string _testFilePath = "test_cars.txt";
        private List<Car> _testCars;

        [TestInitialize]
        public void Setup()
        {
            // Initialize test data before each test
            _testCars = new List<Car>
            {
                // TODO: Add 2-3 sample Car objects here

            };

            // TODO: Clean up any existing test file

        }

        [TestCleanup]
        public void Cleanup()
        {
            // TODO: Clean up test files after tests complete

        }

        [TestMethod]
        public void SaveToFile_CarList_CreatesFileSuccessfully()
        {
            // Arrange
            DataHandler dataHandler = new DataHandler();

            // Act
            // TODO: Call the SaveToFile method with your test file path and cars

            // Assert
            // TODO: Check if the file exists and contains the expected data

        }

        [TestMethod]
        public void ReadFromFile_ValidFile_PrintsCarData()
        {
            // Arrange
            DataHandler dataHandler = new DataHandler();
            // TODO: Create a test file with known car data

            // Act & Assert
            // Since ReadFromFile prints to console and doesn't return a value,
            // testing it directly is challenging. Think about how you might verify it works.
            // Hint: You might need to modify the method to make it more testable

        }

        // TODO: Add additional tests for error cases
    }

    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void ToString_ReturnsFormattedString()
        {
            // Arrange
            Car car = new Car
            {
                // TODO: Initialize car properties

            };

            // Act
            string result = car.ToString();

            // Assert
            // TODO: Check if the string format matches what you expect

        }
    }
}
/*[TestMethod]
public void SaveToFile_CarList_CreatesFileSuccessfully()
{
    // Arrange
    DataHandler dataHandler = new DataHandler();
    
    // Make sure the test file doesn't already exist
    if (File.Exists(_testFilePath))
    {
        File.Delete(_testFilePath);
    }
    
    // Act
    dataHandler.SaveToFile(_testFilePath, _testCars);
    
    // Assert
    Assert.IsTrue(File.Exists(_testFilePath), "The file should be created");
    
    // Read the file content and verify it contains the test car data
    string[] fileLines = File.ReadAllLines(_testFilePath);
    
    Assert.AreEqual(_testCars.Count, fileLines.Length, "The file should contain the same number of lines as cars");
    
    // Check the first car data matches what we expect
    Assert.IsTrue(fileLines[0].Contains(_testCars[0].Make), "The file should contain the car make");
    Assert.IsTrue(fileLines[0].Contains(_testCars[0].Model), "The file should contain the car model");
    Assert.IsTrue(fileLines[0].Contains(_testCars[0].Year.ToString()), "The file should contain the car year");
    Assert.IsTrue(fileLines[0].Contains(_testCars[0].Color), "The file should contain the car color");
}*/