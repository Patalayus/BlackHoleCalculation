using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is my black hole calcualtion
            //this is the first section of code which is executed and it prompts the user for an input.
            Console.WriteLine("This application is designed to allow for a user to be able to enter a speed \n and based on that speed, the program will work out how long it will take for them to travel around Saggitarious A*");
            Console.Write("Please enter your speed in mph: ");

            //this is where I declare the users input as a variable called 'number'.
            double number = Convert.ToInt32(Console.ReadLine());

            ///this is where I declare the variables I am going to use
            ///the topmost variable is the circumference of the black hole in meters
            ///and the bottom most is the circumference of the black hole in miles.
            //double circumference = 138130299800;
            double circumference2 = 85830189.0708264;

            
            double time;

            //this is the predefined algrithm, S=D/T
            time = circumference2 / number;

            //this is where I print out the result.
            Console.WriteLine("\n" + time + " hours observing from earth.");
            double fromship = time / 2;
            Console.WriteLine("\n"+fromship + " hours on the ship.");
            

            double days = time / 24;
            double days2 = fromship / 24;
            double years = days / 365.25;
            double years2 = days2 / 365.25;

            Console.WriteLine("\n" + days + " days on earth.");
            Console.WriteLine("\n" + days2 + " days on the ship");
            Console.WriteLine("\n" + years + " years on earth");
            Console.WriteLine("\n" + years2 + " years on the ship");
            Console.ReadLine();
            ///this means that the distance you have to travel has theoretically halved, but your speed is the same.
            ///actually, its the time in which it takes to go around a black hole which has changed.
        }
    }
}
