using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var descriptionAttribute = field.GetCustomAttributes(typeof(DescriptionAttribute), false)
                                            .FirstOrDefault() as DescriptionAttribute;

            return descriptionAttribute?.Description ?? value.ToString();
        }
    }
    public class StudentGrades

    {
        //Propertise
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public int Minimum { get; set; }
        public int Maximum { get; set; }

        //Attributes
        private void OutputHeading()
        {
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("       Students Marks & Grades          ");
            Console.WriteLine("              by Rayan Hamour                  ");
            Console.WriteLine("--------------------------------------\n");
        }
        //Student names

        public void Run()
        {
            OutputHeading();
            selectMenu();
            InputStudnetName();
            InputMarks();
            OutputMarks();
        }

        public void selectMenu()
        {
            string[] menu = new string[] {
                "Student Name",
                "Enter Marks",
                "Output Marks",
                "Output Stats",
                "Output Grade Profile"
            };

            int select = ConsoleHelper.SelectChoice(menu);
            switch (select)
            {
                case 1:
                    InputStudnetName();
                    break;
                case 2:
                    InputMarks();
                    break;
                case 3:
                    OutputMarks();
                    break;
                case 4:
                    OutputStats();
                    break;
            }
        }
        public void InputStudnetName()

        {

            Students = new string[3];

            for (int i = 0; i < Students.Length; i++)

            {
                Console.Write("Enter first name of student " + (i + 1) + ": ");

                string firstName = Console.ReadLine();

                Console.Write("Enter last name of student " + (i + 1) + ": ");

                string lastName = Console.ReadLine();

                Students[i] = firstName + " " + lastName;
            }

            GradeProfile = new int[(int)Grades.A + 1];

            Marks = new int[Students.Length];

            Console.WriteLine("\nStudents name input complete.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            // Display the options menu
            selectMenu();

        }

        //Input marks
        public void InputMarks()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                bool validInput = false;
                int mark = 0;
                while (!validInput)
                {
                    Console.Write($"Enter mark for {Students[i]}: ");
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out mark))
                    {
                        Console.WriteLine("Error: Please enter a valid integer.");
                    }
                    else if (mark < 0)
                    {
                        Console.WriteLine("Error: Please enter a non-negative integer.");
                    }
                    else if (mark > 100)
                    {
                        Console.WriteLine("Error: Please enter a mark between 0 and 100.");
                    }
                    else
                    {
                        validInput = true;
                    }
                    Marks[i] = mark;
                }
            }
        }
        //Output marks 
        public void OutputMarks()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                string classification = "";
                if (Marks[i] >= 70)
                {
                    classification = "First Class";
                }
                else if (Marks[i] >= 60)
                {
                    classification = "Upper Second Class";
                }
                else if (Marks[i] >= 50)
                {
                    classification = "Lower Second Class";
                }
                else if (Marks[i] >= 40)
                {
                    classification = "Third Class";
                }
                else
                {
                    classification = "Fail";
                }
                Console.WriteLine($"{Students[i]}: {Marks[i]} ({GetGrade(Marks[i])}), {classification}");
            }
            Console.WriteLine();
            Console.WriteLine("\nStudents marks displayed");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            // Display the options menu
            selectMenu();
        }
        private string GetGrade(int mark)
        {
            if (mark < 40)
            {
                return Grades.F.GetDescription();
            }
            else if (mark < 50)
            {
                return Grades.D.GetDescription();
            }
            else if (mark < 60)
            {
                return Grades.C.GetDescription();
            }
            else if (mark < 70)
            {
                return Grades.B.GetDescription();
            }
            else if (mark >= 70)
            {
                return Grades.A.GetDescription();
            }
            else
            {
                return Grades.X.GetDescription();
            }
        }

        public void CalculateStats()
        {
            Minimum = Marks[0];
            Maximum = Marks[0];

            double total = 0;
            foreach (int mark in Marks)
            {
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;
                total = total + mark;
            }

            Mean = total / Marks.Length;
        }

        public void OutputStats()
        {
            CalculateStats();
            // Calculating Mean value
            double overallMean = Mean;
            Console.WriteLine($"Overall Mean: {overallMean.ToString("F")}");

            // Calculating Minimum marks
            int minimumMark = Minimum;
            Console.WriteLine($"Minimum Mark: {minimumMark}");

            // Calculating Maximum marks
            int maximumMark = Maximum;
            Console.WriteLine($"Maximum Mark: {maximumMark}");

            Console.WriteLine("\nMarks input complete.");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            // Display the options menu
            selectMenu();
        }

    }
}
