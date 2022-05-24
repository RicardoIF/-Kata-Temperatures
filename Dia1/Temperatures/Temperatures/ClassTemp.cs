using System;

namespace Temperatures
{
    public enum TemperatureScale {Kelvin, Celsius, Fahrenheit };
    public class ClassTemp
    {
        private TemperatureScale temperatureScale;
        private double value;

        public ClassTemp(double val, TemperatureScale scale)
        {
            temperatureScale = scale;
            value = val;
        }
        public double ToFahrenheit()
        {
            double result = 0;
            if (temperatureScale == TemperatureScale.Kelvin)
            {
                //(k - 273.15)x 1.8 + 32 = f
                result = ((value - 273.15) * 1.8) + 32;
                temperatureScale = TemperatureScale.Kelvin;
            }
            else if (temperatureScale == TemperatureScale.Celsius)
            {
                //(C x 1.8)+32 = f
                result = ((value * 1.8) + 32);
                temperatureScale = TemperatureScale.Celsius;
            }
            else
            {
                result = value;
            }
            value = result;
            return  result;
        }
        public double ToCelsius()
        {
            double result = 0;
            if (temperatureScale == TemperatureScale.Kelvin)
            {
                //(k - 273.15) = C
                result = value - 273.15;
                temperatureScale = TemperatureScale.Kelvin;
            }
            else if (temperatureScale == TemperatureScale.Fahrenheit)
            {
                //((C x -32) * (5/9)) = C
                result = (value - 32) * 0.5556;
                temperatureScale = TemperatureScale.Fahrenheit;
            }
            else
            {
                result = value;
            }
            value = result;
            return result;
        }
        public double ToKelvin()
        {
            double result = 0;
            return result;

        }
    }
}
