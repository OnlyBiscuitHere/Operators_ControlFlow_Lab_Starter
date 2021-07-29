using System.Collections.Generic;
using System.Linq;

namespace Op_CtrlFlow
{
    public class Exercises
    {
        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0;
        }

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {
            double average = 0;
            if (nums.Count > 0)
            {
                average = nums.Average();
            }
            return average;
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {
            string ticketType = string.Empty;
            if (age >= 60)
            {
                ticketType = "OAP";
            }
            else if(age >= 18 && age <= 59)
            {
                ticketType = "Standard";
            }
            else if(age >= 13 && age <= 17)
            {
                ticketType = "Student";
            }
            else  if(age >= 5 && age <=12)
            {
                ticketType = "Child";
            }
            else
            {
                ticketType = "Free";
            }
            return ticketType;
        }

        public static string Grade(int mark)
        {
            var grade = "";
            if(mark >= 40)
            {
                if (mark >= 60)
                {
                    if (mark >= 75)
                    {
                        if (mark <= 100)
                        {
                            grade = "Pass with Distinction";
                        }
                    }
                    else
                    {
                        grade = "Pass with merit";
                    }
                }
                else
                {
                    grade = "Pass";
                }
            }
            else
            {
                grade = "Fail";
            }
            return grade;
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            switch(covidLevel)
            {
                case 4:
                    covidLevel = 20;
                    break;
                case 3:
                    covidLevel = 50;
                    break;
                case 2:
                    covidLevel = 50;
                    break;
                case 1:
                    covidLevel = 100;
                    break;
                case 0:
                    covidLevel = 200;
                    break;
            }
            return covidLevel;
        }
    }
}
