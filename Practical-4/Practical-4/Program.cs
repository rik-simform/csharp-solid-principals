using System;

namespace Practical_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            
            Console.Write("Enter Student Name: ");
            //enter student name
            std.name = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            //loop will iterate until array length
            for (int i = 0; i < std.marks.Length; i++)
            {
                //user enter marks
                Console.Write("Enter Subject No. " + (i+1) +": ");
                std.marks[i] = Convert.ToDecimal(Console.ReadLine());
            }

            var average = std.CalculateAvgMarks();

            Console.WriteLine("The Average is: " + average );

            Console.WriteLine(std.CalculateGrade(average));
        }
    }
}
