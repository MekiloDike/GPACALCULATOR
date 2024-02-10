using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACALCULATOR
{
    internal class GPAInput
    {
        public static string InputCourseCode()
        {
            //validate courseCode
            string courseCode;
            do
            {
                Console.WriteLine("please enter course name and code");
                courseCode = Console.ReadLine();
                if (string.IsNullOrEmpty(courseCode))
                {
                    Console.WriteLine("course code cannot be empty");
                }
            }
            while (string.IsNullOrEmpty(courseCode));
            
            return courseCode;
        }
        public static int InputCourseUnit()
        {
            //validate course unit input
            string input;
            int courseUnit = 0;
            bool isValidNumber = false;
            do
            {
                Console.WriteLine("please enter course unit");
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("course unit cannot be empty");
                    continue;
                }

                isValidNumber = int.TryParse(input, out courseUnit);

                if (!isValidNumber)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }
                if (courseUnit <= 0||courseUnit > 10)
                {
                    Console.WriteLine("course unit should be from 1 to 10");
                    isValidNumber = false;
                }
            }
            while (string.IsNullOrEmpty(input) || !isValidNumber || courseUnit <= 0 || courseUnit > 10);

            return courseUnit;
        }
        public static int InputCourseScore()
        {
            //validate course score
            int courseScore = 0;
            string input;
            bool isValidNumber = false;
            do
            {
                Console.WriteLine("please enter course score");
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("course score cannot be empty");
                    continue;
                }
                 isValidNumber = int.TryParse(input, out courseScore);
                if (!isValidNumber)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                if (courseScore < 0 || courseScore > 100)
                {
                    Console.WriteLine("course score should be between zero and 100");
                }
            }
            while (courseScore < 0 || courseScore > 100 || string.IsNullOrEmpty(input) || !isValidNumber);

            return courseScore;
        }

        public static string AddAnotherCourse()
        {
            bool isYesOrNo = false;
            string anotherCourse;
            do
            {
                Console.WriteLine("do you want to enter another course: Y/N");
                anotherCourse = Console.ReadLine().ToUpper();

                if (string.IsNullOrEmpty(anotherCourse))
                {
                    Console.WriteLine("input cannot be empty");
                    continue;
                }

                if (anotherCourse == "Y" || anotherCourse == "N")
                {
                    isYesOrNo = true;
                }
                else
                {
                    Console.WriteLine("Please enter Y or N");
                }
            }
            while (string.IsNullOrEmpty(anotherCourse) || !isYesOrNo);
            return anotherCourse;
        }

    }
}
