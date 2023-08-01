using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            ElementarySchoolGradeCard elementary = new ElementarySchoolGradeCard();
            elementary.Maths = 90;
            elementary.English = 78;
            elementary.SecondLanguage = 80;
            elementary.SocialScience = 67;
            Console.WriteLine("**ELementary School Grade Marks**\n");
            Console.WriteLine("Total marks =" +
                              elementary.getTotalMarks());

            MiddleSchoolGradeCard middle = new MiddleSchoolGradeCard();
            middle.Maths = 90;
            middle.English = 78;
            middle.SecondLanguage = 80;
            middle.Geography = 87;
            middle.History = 76;
            Console.WriteLine("**Middle School Grade Marks**\n");
            Console.WriteLine("Total marks =" + middle.getTotalMarks());

            HighSchoolgradeCard high = new HighSchoolgradeCard();
            high.Maths = 90;
            high.English = 78;
            high.SecondLanguage = 80;
            high.Geography = 87;
            high.History = 76;
            high.Physics = 90;
            high.Chemistry = 76;
            high.Biology = 70;
            Console.WriteLine("**High  School Grade Marks**\n");
            Console.WriteLine("Total marks =" + high.getTotalMarks());
            Console.ReadKey();
        }
    }
}

    