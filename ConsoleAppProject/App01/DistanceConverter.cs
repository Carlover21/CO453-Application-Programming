using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    {
        double miles, kilometers, meters, centimeters, feet, inches;

        public void Run()
        {
            Console.WriteLine("Welcome to the Distance Converter App!");
            Console.WriteLine("Please enter the value to convert: ");

            double value = double.Parse(Console.ReadLine());

            miles = value * 0.000621371;
            kilometers = value * 0.001;
            meters = value;
            centimeters = value * 100;
            feet = value * 3.28084;
            inches = value * 39.3701;

            Console.WriteLine("{0} meters is equal to {1} miles.", meters, miles);
            Console.WriteLine("{0} meters is equal to {1} kilometers.", meters, kilometers);
            Console.WriteLine("{0} meters is equal to {1} feet.", meters, feet);
            Console.WriteLine("{0} meters is equal to {1} inches.", meters, inches);
            Console.WriteLine("{0} meters is equal to {1} centimeters.", meters, centimeters);

            Console.ReadKey();
        }

    }
}
