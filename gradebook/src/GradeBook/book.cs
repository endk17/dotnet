using System;
using System.Collections.Generic;

namespace GradeBook
{  
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void showstatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }
            result /= grades.Count;
            Console.WriteLine($"The lowsest grade is: {lowGrade}");
            Console.WriteLine($"The highest grade is: {highGrade}");
            Console.WriteLine($"The average grade is: {result:N3}");
        }

        private List<double> grades;
        private string name;
    }
}