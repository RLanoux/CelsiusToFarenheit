using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CelsiusToFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            double Celsius = 37;
            double Fahrenheit;

            //Calculate the temperature in Farenheit
            Farenheit = (Celsius * 9 / 5) + 32;

            //Show what the temperature is
            Console.WriteLine("{0:##.##} degrees Celsius converts to " + 
                              "{1:##.##} degrees Fahrenheit.", Celsius, Fahrenheit);
            Console.ReadLine();

        }
    }
}
