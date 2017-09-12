using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
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
            */

            //string myFirstName;
            //myFirstName = "Will";

            //var myfirstname = "Will";

            //string myFirstName = "Will";


            //string myfirstname;
            //this is a totally different variable because
            //it has no uppercase

            //Console.WriteLine(myfirstname);

            int x = 7;
            //string y = "Will";
            string y = "5";
            string myFirstTry = x.ToString() + y;
            //this combines an integer and a string together into a new string

            //int mySecondTry = x + y;
            int mySecondTry = x + int.Parse(y);
            //for converting strings into integers

            Console.WriteLine(myFirstTry);
            //^^this works out to equal 75 (didn't actually add though)
            //Console.WriteLine(mySecondTry);
            //^^this works out to equal 12



            Console.ReadLine();

        }
    }
}
