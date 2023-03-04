using ConsoleAppProject.App01;
//using ConsoleAppProject.App02;


namespace ConsoleUnit_Test
{
    [TestClass]
    public class UnitTestApp1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.inputUnit = "miles";
            converter.outputUnit = "kilometers";
            converter.distance = 60;

            converter.ConvertDistance();

            double expectedDistance = 100;

            Assert.AreEqual(expectedDistance, converter.result);
        }
    }
}