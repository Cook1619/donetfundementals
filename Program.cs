using System;
using GradeBook;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(89.3);
            var grades = new List<double>() {12.3, 45.3, 23.6, 67.3};
            grades.Add(67.8);

            var result = 0.0;
            foreach (var num in grades)
            {
                result += num;
            }
            result /= grades.Count;
            
            Console.WriteLine($"The average grade is {result:N1}");
        }
    }
}
