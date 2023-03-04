using ConsoleAppProject.App01;

using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Derek Peacock 05/02/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Witch app would you like to choose:");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                DistanceConverter converter = new DistanceConverter();
                converter.Run();
            }
            else if (choice == "2")
            {
                BMI calculator = new BMI();
                calculator.Run();
            }
            else
            {
                Console.WriteLine("The number is invalid !!!!");
            }
            

           
        }
    }
}
