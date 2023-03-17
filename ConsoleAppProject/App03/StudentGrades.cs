using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentMarks
    {
        public string Name;
        public string Surname;
        public int Marks;
        public string A, B, C, D, F;
        public const int Max_Students = 10;

        public void run()
        {
            Console.WriteLine("    Welcome to Student mark app by Rayan Hamour    ");
            ConvertToMarks();
            Names();
            GetStudentMarks();
        }
        public string ConvertToMarks()
        {
            switch (Marks)
            {
                case int n when (n >= 70):
                    return "A";
                case int n when (n >= 60):
                    return "B";
                case int n when (n >= 50):
                    return "C";
                case int n when (n >= 40):
                    return "D";
                case int n when (n >= 0):
                    return "F";
                default:
                    return "Invalid Mark Please Try Again";
            }
        }
        public string Names()
        {
            return $"{Name}  {Surname}";
        }
        public void GetStudentMarks()
        {
            List<StudentMarks> studentMarksList = new List<StudentMarks>();
            int min = int.MaxValue;
            int max = int.MinValue;
            double mean = 0;
            for (int i = 0; i < Max_Students; i++)
            {
                Console.WriteLine("Enter the name of the student:   ");
                string name = Console.ReadLine();

                StudentMarks sg = new StudentMarks();
                
                    Name = name;
            
            
                Console.WriteLine("Enter Student Marks:  ");
                int marks = Convert.ToInt32(Console.ReadLine());
                sg.Marks = Marks;
                studentMarksList.Add(sg);

                if (marks > max)
                    max = marks;
                if (min > max)
                    min = max;
                mean += marks;
            }
            mean = mean / studentMarksList.Count;

            Console.WriteLine("The list of students and their grades:  ");
            foreach (StudentMarks sg in studentMarksList) { }
            {
                Console.WriteLine($"{Names()} Grades: {ConvertToMarks()}");
            }

            Console.WriteLine("The avreage , minimum and maximum marks are:  ");
            Console.WriteLine($"Mean: {mean}, Min: {min}, Max: {max}"); 

        }
    }
}
