﻿using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
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
            Console.WriteLine(" ====================================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2022-2023! By Rayan Hamour    ");
            Console.WriteLine(" ====================================================================");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Witch app would you like to choose:");
            string choice = Console.ReadLine();

            if (choice == "2")
            {
                BMI calculator = new BMI();
                calculator.Run();
            }
            if (choice == "3")
            {
                StudentGrades stu = new StudentGrades();
                stu.Run();
                
            }
            if (choice == "4")
            {
                SocialNetwork app = new SocialNetwork();
                app.DisplayMenu();

            }
            else
            {
                Console.WriteLine("The number is invalid !!!!");
            }
            

           
        }
    }
}
