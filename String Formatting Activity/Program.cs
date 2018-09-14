using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Formatting_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks the user for a number with a decimal and converts it to a double
            Console.WriteLine("Can you give me a number with a decimal?");
            String inputNumber = Console.ReadLine();
            double userNumber = double.Parse(inputNumber);

            //Prints out the user's number in three different formats
            string currencyNumber = userNumber.ToString("C2");
            string percentageNumber = userNumber.ToString("P0");
            string groupingNumber = userNumber.ToString("N1");

            Console.WriteLine(currencyNumber);
            Console.WriteLine(percentageNumber);
            Console.WriteLine(groupingNumber);

            Console.WriteLine();

            //Creating a single string using placeholders

            Console.WriteLine("I just printed out {0},{1}, and {2}",    currencyNumber,
                percentageNumber,
                groupingNumber);

            //Storing the string as a variable and printing it out
            string sentence = string.Format("I just printed out {0},{1}, and {2} ", currencyNumber,
                percentageNumber,
                groupingNumber);
            Console.WriteLine(sentence);

            Console.WriteLine();

            Console.WriteLine("I just printed out {0}, {1}, and {2}", currencyNumber, percentageNumber, groupingNumber);
        }
    }
}
