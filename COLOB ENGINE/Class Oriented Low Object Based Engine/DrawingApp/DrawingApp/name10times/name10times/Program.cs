using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name10times
{
    class Program
    {
        static void Main(string[] args)
        {
            //title
            string title = "My name printed 10 times";
            Console.Title = title;


            //variable for my name
             string myName = "Name" +
                "";
            string space = " ";


            //loop for name
            int i = 1;
            while(i <= 15)
            {
                Console.WriteLine(i.ToString() + ". " + space + myName);
                Console.ReadKey();

                if (i == 1)
                    space = null;
                else if (i == 2)
                    space = " ";
                else if (i == 3)
                    space = "  ";

                else if (i == 4)
                    space = "   ";
                else if (i == 5)
                    space = "    ";
                else if (i == 6)
                    space = "      ";
                else if (i == 7)
                    space = "       ";
                else if (i == 8)
                    space = "        ";
                else if (i == 9)
                    space = "         ";
                else if (i == 10)
                    space = "        ";
                else if (i == 11)
                    space = "       ";
                else if (i == 12)
                    space = "      ";
                else if (i == 13)
                    space = "     ";
                else if (i == 14)
                    space = "   " +
                        " ";
                else if (i == 15)
                    space = "     ";


                i++;
            }
            Console.ReadKey();
        }

    }
}
