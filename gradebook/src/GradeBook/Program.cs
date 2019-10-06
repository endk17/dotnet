using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("TEST Grades");
            book.AddGrade(35.1);
            book.AddGrade(95.9);
            book.AddGrade(77.5);
            book.showstatistics();
        }
    }
}
