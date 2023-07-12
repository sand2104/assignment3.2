using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3._2
{
    internal class Program
    {
        static void Main()
        {
            // Convert string to integer using TryParse
            Console.Write("Enter an integer: ");
            string intInput = Console.ReadLine();

            if (int.TryParse(intInput, out int intValue))
            {
                int multipliedValue = intValue * 5;
                Console.WriteLine("Conversion successful! Multiplied value: " + multipliedValue);
            }
            else
            {
                Console.WriteLine("Conversion to integer failed. Please enter a valid integer.");
            }

            // Convert string to DateTime using Convert
            Console.Write("Enter a date and time (yyyy-MM-dd HH:mm:ss): ");
            string dateTimeInput = Console.ReadLine();

            try
            {
                DateTime convertedDateTime = Convert.ToDateTime(dateTimeInput);
                DateTime subtractedDateTime = convertedDateTime.AddMonths(-1);
                Console.WriteLine("Conversion successful! Subtracted 1 month: " + subtractedDateTime);
            }
            catch (FormatException)
            {
                Console.WriteLine("Conversion to DateTime failed. Please enter a valid date and time format.");
            }

            // Convert string to TimeSpan using Parse
            Console.Write("Enter a time span (hh:mm:ss): ");
            string timeSpanInput = Console.ReadLine();

            try
            {
                TimeSpan parsedTimeSpan = TimeSpan.Parse(timeSpanInput);
                TimeSpan addedTimeSpan = parsedTimeSpan.Add(new TimeSpan(2, 0, 0));
                Console.WriteLine("Conversion successful! Added 2 hours: " + addedTimeSpan);
            }
            catch (FormatException)
            {
                Console.WriteLine("Conversion to TimeSpan failed. Please enter a valid time span format.");
            }
        }
    }
