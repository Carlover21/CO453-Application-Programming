using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
            Console.WriteLine("    Welcome to Student mark app by Rayan Hamour    ";
            ConnvertToMarks();
            Name();
            GetStudentMarks();
        }
        public string ConvertToMarks()
        {
            switch (Marks)
            {
                case int n when (n >= 70):
                    return "A"
                case int n when (n >= 60):
                    return "B"
                case int n when (n >= 50):
                    return "C"
                case int n when (n >= 40):
                    return "D"
                case int n when (n >= 0):
                    return "F"
                default:
                    return "Invalid Mark Please Try Again";
            }
        }
        public string Name()
        {
            return$ "{Name}  {Surname}";
        }
        public void GetStudentMarks()
        {
            List<StudentMarks> studentMarksList = new List<StudentMarks>();
            int min = int.MaxValue;
            int max = int.MinValue;
            double mean = 0;
            for (int i=0; i<Max_Students; i++)
            {
                Console.WriteLine("Enter the name of the student:   ");
                string name = Console.ReadLine();

                StudentMarks 
            }
        
        }
    }