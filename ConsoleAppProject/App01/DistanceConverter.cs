using System;

namespace ConsoleAppProject.App01
{

    public class DistanceConverter
    {
        public string inputUnit;
        public string outputUnit;
        public double distance;
        public double result;

    

    
        public void Run()
        {
            Console.WriteLine("Welcome to Advanced Distance Converter!");

            // Display the list of available units
            Console.WriteLine("Please select the input unit:");
            DisplayUnitList();
            inputUnit = Console.ReadLine();

            Console.WriteLine("Please select the output unit:");
            DisplayUnitList();
            outputUnit = Console.ReadLine();

            Console.WriteLine("Please enter the distance value:");
            distance = double.Parse(Console.ReadLine());

            // Convert the distance to the desired unit
            result = ConvertDistance();

           

            // Method to display the list of available units
            static void DisplayUnitList()
        {
            Console.WriteLine("1. Kilometer (km)");
            Console.WriteLine("2. Meter (m)");
            Console.WriteLine("3. Centimeter (cm)");
            Console.WriteLine("4. Millimeter (mm)");
            Console.WriteLine("5. Mile (mi)");
            Console.WriteLine("6. Yard (yd)");
            Console.WriteLine("7. Foot (ft)");
            Console.WriteLine("8. Inch (in)");
        }

        // Method to convert the distance to the desired unit
        public double ConvertDistance()
        {

            double result = 0;

            // Use a switch statement to handle each conversion case
            switch (inputUnit)
            {
                case "1":
                    switch (outputUnit)
                    {
                        case "2":
                            result = distance * 1000;
                            break;
                        case "3":
                            result = distance * 100000;
                            break;
                        case "4":
                            result = distance * 1000000;
                            break;
                        case "5":
                            result = distance * 0.621371;
                            break;
                        case "6":
                            result = distance * 1093.61;
                            break;
                        case "7":
                            result = distance * 3280.84;
                            break;
                        case "8":
                            result = distance * 39370.1;
                            break;
                        default:
                            break;
                    }
                    break;
                case "m":
                    switch (outputUnit)
                    {
                        case "km":
                            result = distance / 1000;
                            break;
                        case "cm":
                            result = distance * 100;
                            break;
                        case "mm":
                            result = distance * 1000;
                            break;
                        case "mi":
                            result = distance * 0.000621371;
                            break;
                        case "yd":
                            result = distance * 1.09361;
                            break;
                        case "ft":
                            result = distance * 3.28084;
                            break;
                        case "in":
                            result = distance * 39.3701;
                            break;
                        default:
                            break;
                    }
                    break;
                case "cm":
                    // Handle the remaining conversion cases in a similar way
                    break;
                case "mm":
                    break;
                case "mi":
                    break;
                case "yd":
                    break;
                case "ft":
                    break;
                case "in":
                    break;
                default:
                    break;
            }

            return result;
                
            }
            // Output the result
            Console.WriteLine("{0} {1} is equal to {2} {3}.", distance, inputUnit, result, outputUnit);
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();


        }
}
