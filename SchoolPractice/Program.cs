using System;

namespace SchoolPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student NonRoboticStudent = new Student("Natasha", 23669, 1, 4.0);
            Console.Write($"{NonRoboticStudent.Name} with id {NonRoboticStudent.StudentId} has {NonRoboticStudent.NumberOfCredits} credit hour(s) and a GPA of {NonRoboticStudent.Gpa}");
        }
    }
}
