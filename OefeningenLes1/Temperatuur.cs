using System;
using System.Collections.Generic;
using System.Text;

namespace Oefening2
{
    class Temperatuur
    {
        public Temperatuur(float celcius)
        {
            this.Celcius = celcius;
        }

        public float Celcius { get; set; }

        public float Fahrenheit
        {
            get
            {
                return this.Celcius * 9 / 5 + 32;
            }
        }

        public float Kelvin
        {
            get
            {
                return this.Celcius + 273.15f;
            }
        }

        public override string ToString()
        {
            return $"Celcius: {this.Celcius}°C, Fahrenheit: {this.Fahrenheit}°F, Kelvin: {this.Kelvin}K";
        }
    }
}
