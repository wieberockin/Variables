using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             int x;
             int y;
             x = 7;
             y = x + 3;
             Console.WriteLine(y);
             Console.Readline()
             */

            Console.WriteLine("What is Your name?");
            Console.Write("Type your first name: ");
            string myFirstName = Console.ReadLine();
            //This is the change that I want to add to the next commit

            //string myLastName;
            //Console.Write("Type your last name: ");
            //myLastName = Console.ReadLine();

            Console.WriteLine("Type your last name: ");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello " + myFirstName + " " + myLastName);
            Console.ReadLine();


            
        }
    }
}
