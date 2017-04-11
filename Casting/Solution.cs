using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Solution
    {
        static void Main(string[] args)
        {
            int num = 5;
            int value = 0;
            // string str = "5";
            Label: 
            Console.WriteLine("Please enter a valid number");
            string str = Console.ReadLine();
            //string str = "x";

            
            try
            {
               value = num + Int32.Parse(str);
                Console.WriteLine(value);

            }
            catch (FormatException)
            {

                Console.WriteLine("Your string must be a valid number, please try again");
                goto Label;


            }
            Console.WriteLine("Your number added to five is: " + value);

            Console.ReadLine();
        }
    }
}
