using System;
using System.Collections.Generic;
using System.IO;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("Cannot Divide by Zero");
            }
            return x / y;
        }

        static int CheckFileExtension(string fileName)
        {
            if (fileName.Equals("") || fileName.Equals(null))
            {
                throw new FormatException("The File / FileName is Empty");
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
            try
            {
                Console.WriteLine(Divide(42, 0));
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (KeyValuePair<string, string> submission in students)
            {
                int grade = -1;
                try
                {
                    grade = CheckFileExtension(submission.Value);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Student: " + submission.Key + ": " + e.Message);
                }
                if (grade == 0 || grade == 1)
                {
                    Console.WriteLine("Student: " + submission.Key + ": " + grade * 100 + "%");
                }
            }
        }
    }
}
