using System;
using System.Collections.Generic;
using System.Text;

namespace Staticclass
{
    public class Practicingstatic
    {
        
        
        public static decimal CelsiusToFahrenhet(string temperatureCelsius)
        {
            decimal celsius = decimal.Parse(temperatureCelsius);
            decimal Fahrenheat = (celsius * 9 / 5) + 32;
            return Fahrenheat;
        }

        public static decimal FahrenheatToCelsisu(string temperatureFahrenheit)
        {
            decimal Fahrenheat = decimal.Parse(temperatureFahrenheit);
            decimal celsius = (Fahrenheat - 32) * 5 / 9;
            return celsius;
        }
    }
}
