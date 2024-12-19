using System;
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;
using Assignment.Collections;
using System.Text.RegularExpressions;
using System.Diagnostics.Metrics;

namespace Assignment
{
    
    class Program
    {

        static void Main()
        {

            #region 1. Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.Then, write a C# program that prints out all the days of the week using this enum.


            //foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            //{
            //    Console.WriteLine(day);
            //}


            #endregion


            #region 2. Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members.Write a C# program that takes a season name as input from the user and displays the corresponding month rangefor that season. Note range for seasons(spring march to may, summerjune to august, autumn September to November, winter December to February)

            //do
            //{
            //    Console.WriteLine("Please write the season (Spring, Summer, Autumn, Winter).");
            //    Console.WriteLine();
            //    Console.Write("Please write the season : ");
            //    string InputSeason = Console.ReadLine();
            //    bool isValidSeason = Enum.TryParse(InputSeason, true, out Seasons season);
            //    if (isValidSeason)
            //    {

            //        if (season == Seasons.Spring)
            //        {
            //            Console.WriteLine("March, April, May");

            //        }
            //        else if (season == Seasons.Summer)
            //        {
            //            Console.WriteLine("June, July, August");

            //        }
            //        else if (season == Seasons.Autumn)
            //        {
            //            Console.WriteLine("September, October, November");

            //        }
            //        else if (season == Seasons.Winter)
            //        {
            //            Console.WriteLine("December, January, February");
            //        }
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your input is invalid. Please enter a valid season (Spring, Summer, Autumn, Winter).");
            //    }

            //} while (true);






            //// Switch حل آخر بإستخدام 
            //do
            //{
            //    Console.WriteLine("Please write the season (Spring, Summer, Autumn, Winter).");
            //    Console.WriteLine();
            //    Console.Write("Please write the season : ");
            //    string InputSeason = Console.ReadLine();
            //    bool isValidSeason = Enum.TryParse(InputSeason, true, out Seasons season);
            //    if (isValidSeason)
            //    {
            //        switch (season)
            //        {
            //            case Seasons.Spring:
            //                Console.WriteLine("March, April, May");
            //                break;
            //            case Seasons.Summer:
            //                Console.WriteLine("June, July, August");
            //                break;
            //            case Seasons.Autumn:
            //                Console.WriteLine("September, October, November");
            //                break;
            //            case Seasons.Winter:
            //                Console.WriteLine("December, January, February");
            //                break;
            //        }
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your input is invalid. Please enter a valid season (Spring, Summer, Autumn, Winter).");
            //    }

            //} while (true);


            #endregion


            #region 3. Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.

            //Permissions Mypermissioms = Permissions.Read;
            //Console.WriteLine(Mypermissioms);
            //Mypermissioms |= Permissions.Write;
            //Mypermissioms |= Permissions.Delete;
            //Mypermissioms |= Permissions.Execute;
            //Mypermissioms &= ~(Permissions.Execute);
            //Mypermissioms &= ~(Permissions.Delete);
            //Mypermissioms &= ~(Permissions.Write);
            //Console.WriteLine(Mypermissioms);

            /////Another solution
            //Permissions Mypermissioms = Permissions.Read;
            //Mypermissioms |= Permissions.Write;
            //Mypermissioms |= Permissions.Delete;
            //Console.WriteLine(Mypermissioms);
            //if ((Mypermissioms & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("Read permission exists.");
            //}

            //if ((Mypermissioms & Permissions.Execute) != Permissions.Execute)
            //{
            //    Console.WriteLine("Execute permission does not exist.");
            //}
            //Mypermissioms &= ~Permissions.Write;
            //Console.WriteLine(Mypermissioms);
            //Mypermissioms |= Permissions.Execute;
            //Console.WriteLine(Mypermissioms);

            #endregion


            #region 4. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            
            //Console.WriteLine("Please Enter The color (Red, Green, Blue,) : ");
            //String? Color = Console.ReadLine();
            //if (Enum.TryParse(Color, true, out Colors color))
            //{
            //    Console.WriteLine($"{color} is a primary color");
            //}
            //else
            //{
            //    Console.WriteLine($"{Color} is not a primary color.");
            //}

            #endregion

        }
    }
}



