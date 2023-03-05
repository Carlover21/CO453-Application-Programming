using System;

namespace ConsoleAppProject
{
    public class BMI
    {
        public void Run()
        {
            Console.WriteLine("Welcome to the Advanced BMI Calculator!");
            Console.WriteLine("By Rayan Hamour");   
            // Ask user for unit of measurement preference
            Console.WriteLine("Please select your preferred unit of measurement:");
            Console.WriteLine("1. Imperial (pounds, inches)");
            Console.WriteLine("2. Metric (kilograms, meters)");
            int unitChoice = Convert.ToInt32(Console.ReadLine());

            // Ask user for weight and height
            Console.Write("Enter your weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            // Calculate BMI based on selected unit of measurement
            double bmi;
            string unitOfMeasurement;
            if (unitChoice == 1)
            {
                bmi = (weight * 703) / (height * height);
                unitOfMeasurement = "imperial";
            }
            else
            {
                bmi = weight / (height * height);
                unitOfMeasurement = "metric";
            }

            // Display BMI and corresponding weight status
            Console.WriteLine($"Your BMI is {bmi:F2} ({unitOfMeasurement} units).");
            if (bmi < 18.5)
            {
                Console.WriteLine("You are underweight.");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("You are at a healthy weight.");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("You are overweight.");
            }
            else
            {
                Console.WriteLine("You are obese.");
            }

            Console.ReadLine();
        }
    }
}
