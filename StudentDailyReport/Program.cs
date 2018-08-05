using System;

namespace StudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {//Variables and Data Types Exercise

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            string courseNumber = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pagNum = Convert.ToInt32(pageNumber);

            Console.WriteLine("Do you need help with anything? Please answer TRUE or FALSE");
            string needHelp = Console.ReadLine();
            bool neeHel = Convert.ToBoolean(needHelp);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            int houStu = Convert.ToInt32(hoursStudied);

            Console.WriteLine("Thank you for your answers.  An instructor will respond to this shortly.  Have a great Day!");
            Console.ReadLine();
            
        }
    }
}
