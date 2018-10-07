using System;
using System.Linq;

namespace starstack
{
    class Program
    {
        static void Main(string[] args)
        {

            //     *
            //    **
            //   ***
            //  ****
            // *****
            //******


            //created a for loop, since i want there to be 1 star on the first line,
            //i started my integer value at 1 instead of 0
            //i want the last line to have 6 stars, so end integer value is 6

            for (int i = 1; i <= 6; i++)
            {   

                //figured out two ways to do this: first using a string constructor new string('stringvalue', length)
                //second is String.Concat(Enumerable.Repeat("stringvalue", length)


                //string spaces = new string(' ', 6 - i);

                string spaces = String.Concat(Enumerable.Repeat(" ", 6 - i));

                //string stars = new string('*', i);

                string stars = String.Concat(Enumerable.Repeat("*", i));

                
                //write solution to console
                Console.WriteLine($"{spaces}{stars}");

            }


            Console.ReadLine();

        }
    }
}
