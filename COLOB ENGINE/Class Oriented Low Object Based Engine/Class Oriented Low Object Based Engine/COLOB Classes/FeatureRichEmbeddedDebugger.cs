using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Oriented_Low_Object_Based_Engine.COLOB_Classes
{
    public class FeatureRichEmbeddedDebugger
    {

        //This is a logging system which you can use to log messages for debugging
        //It will also throw you errors when necessary
        //This can be used as a shorthand way to write Console.WriteLine(string);

         //Print any message
        public static void Generic(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Prints informationa messages
        public static void Info(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Info: " + message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Prints warning messages
        public static void Warning(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Warning: " + message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Prints error messages
        public static void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: " + message);
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
