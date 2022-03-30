using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Practical_4
{

    enum Options
    {
        Aggregrate =1,
        MinMarks =2,
        MaxMarks =3,
        Grade=4
    }
    class Student
    {
        public string name;
        public decimal[] marks =  new decimal[5];
        public static decimal AvgMarks;

        public decimal CalculateAvgMarks()
        {
            decimal sum = 0;
            for (int i=0; i<marks.Length; i++)
            {
                
                sum += marks[i];
            }
            AvgMarks = sum / marks.Length;
            return AvgMarks;
        }

        public string CalculateGrade(decimal marks)
        {
            string grade = null;


            //bool flag = true;

            while (true)
            {

                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("Press 1 - Aggregate: Displays the Name: Average marks ");
                Console.WriteLine("Press 2 - MinMark: Displays the minimum marks of the student");
                Console.WriteLine("Press 3 - MaximumMark: Displays the maximum mark");
                Console.WriteLine("Press 4 - Grade: Displays grade");
                Console.WriteLine("Press 0 - To EXIT");
                
                Console.WriteLine("------------------------------------------------------------");
                Console.Write("Give Choice: ");
                int ch = Convert.ToInt32(Console.ReadLine());

                if (ch == 0)
                {
                    break;
                }
                else
                {
                    switch (ch)
                    {
                        case (int)Options.Aggregrate:
                            
                            Console.WriteLine("The name of student is " + name + " and his Average is " + AvgMarks + "\n");
                            break;

                        case (int)Options.MinMarks:
                            
                            Console.WriteLine("The Minimum marks of the student is " + this.marks.Min() + "\n");
                            break;
                        case (int)Options.MaxMarks:
                            
                            Console.WriteLine("The Maximum marks of the student is " + this.marks.Max() + "\n");
                            break;
                        case (int)Options.Grade:
                            if (marks > 90)
                            {
                                
                                Console.WriteLine("Garde A" + "\n");
                            }
                            else if (marks < 80)
                            {
                                
                                Console.WriteLine("Garde B" + "\n");
                            }
                            else if (marks > 70)
                            {
                                
                                Console.WriteLine("Garde C" + "\n");
                            }
                            else if (marks < 70)
                            {
                                
                                Console.WriteLine("Garde D" + "\n");

                            }
                            break;
                        default:
                            Console.WriteLine("wrong option chosen" + "\n");
                            break;
                    }
                }
               
            }
            return grade;
        
    }
    }
}
