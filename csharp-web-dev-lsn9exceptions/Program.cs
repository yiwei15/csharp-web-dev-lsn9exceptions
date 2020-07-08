using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            // Write your code here!
            // Validate y before executing x/y

            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("You can't divide by zero");
            }
            double result =  x / y;
            return result;


            //try
            //{
            //    return x / y;
            //}

            //catch(ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

        }

        static int CheckFileExtension(string fileName)
        {
            // Write your code here!
            if (fileName ==null || fileName.Equals(""))
            {
                throw new ArgumentNullException("Empty fileName passed in.");
            }   
            else if (fileName.EndsWith(".cs"))
            {
                return 1;
            }
            return 0;

        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!

            double totalPoints;
            double totalPossiblePoints;
            Console.WriteLine("Please enter the total points: ");
            totalPoints = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the total possible points: ");
            totalPossiblePoints = double.Parse(Console.ReadLine());
            //double grade = Divide(totalPoints, totalPossiblePoints);
            //Console.WriteLine("Grade: " + grade);

            try
            {
                double result1 = Divide(totalPoints, totalPossiblePoints);
                Console.WriteLine(result1);

            } catch(ArgumentOutOfRangeException e) //e-varaible to hold the exception object
            {
                Console.WriteLine(e.Message);
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach(KeyValuePair<string, string> student in students)
            {   
                try
                {
                    int points = CheckFileExtension(student.Value);
                    Console.WriteLine(student.Key + " gets " + points + "points.");
                } catch(ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(student.Key + " has invalid fileNanme.");
                }

            }

        }
    }
}
