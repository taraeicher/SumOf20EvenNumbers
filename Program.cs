using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Project: Loops Part One #1
 * Programmer: Tara Eicher
 * Date: 18 November 2010
 * Description: Display the sum of the first 20 even numbers entered.
 */ 

namespace Loop1
{
    class Program
    {
        static void Main(string[] args)
        {
            int intNum = 0, intSum = 0, n = 0; //counter
            string strNum;
            while (n < 20)
            {
                Console.Write("Please enter a number.");
                strNum = Console.ReadLine();
                try
                {
                    intNum = int.Parse(strNum);
                    if (intNum % 2 == 0) //Only increment and sum when number is even.
                    {
                        ++n;
                        intSum += intNum;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Entry. Please try again."); 
                }
            }
            Console.WriteLine("The sum of these 20 even numbers is " + intSum.ToString("N0")+
                ".");
            Console.WriteLine();
            Console.Write("Press any key to quit");
            Console.ReadKey();
        }
    }
}
