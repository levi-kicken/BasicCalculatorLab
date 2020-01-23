using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** WEATHER  CALCULATOR ***");

            Console.WriteLine("Enter Temperature (Fahrenheit)");

            // int.Parse will take a string data type and convert it to an int data type
            int temp = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Relative Humidity");
            int humid = int.Parse(Console.ReadLine());

            int dew = temp - (9*(100 - humid))/25;

            Console.WriteLine("The dew point is " + dew);

            Console.WriteLine("Enter Windspeed (mph)");

            int windspd = int.Parse(Console.ReadLine());

            double windchill = 35.74 + (0.6215 * temp) - (35.75 * Math.Pow(windspd, .16)) + (0.4275 * temp * Math.Pow(windspd, 0.16));

            Console.WriteLine("The wind chill is " + windchill);

        }
    }
}
