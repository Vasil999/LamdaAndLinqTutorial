using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student() {FirstName = "Kalin", LastName = "Javorov", Age = 29},
                new Student() {FirstName = "Irena", LastName = "Georgieva", Age = 30},
                new Student() {FirstName = "Pesho", LastName = "Ivanov", Age = 29},
                new Student() {FirstName = "Gosho", LastName = "Lambev", Age = 29},
                new Student() {FirstName = "Penka", LastName = "Filipova", Age = 21},
                new Student() {FirstName = "Ginka", LastName = "Varbanova", Age = 20},
            };

            var comparedStudents = students.OrderByNames().Select(s => new { Name = s.FirstName + " " + s.LastName, Age = s.Age});
            Console.WriteLine(string.Join(", ", comparedStudents));

            var studentsByAge = students
                .Where(s => s.Age > 18 && s.Age < 24)
                .Select(s => new { Name = s.FirstName + " " + s.LastName, Age = s.Age});

            Console.WriteLine(string.Join(", ", studentsByAge));
        }

        
                         
    }

    public static class StudentExtensions
    {
        public static List<Student> OrderByNames(this Student[] students)
        {
            return students.Where(s => s.FirstName.CompareTo(s.LastName) < 0).ToList();
        }
    }
}
