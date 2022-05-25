using System;

namespace ClassTemp
{
    public enum Scale {Kelvin, Celcius, Fahrenheit}
    public class ClassTemperatures
    {
        private double temperature;
        private Scale scale;
        public ClassTemperatures(double temp, Scale _scale)
        {
            temperature = temp;
            scale = _scale;
        }
        public double ToFahrenheit()
        {
            switch (scale)
            {
                case Scale.Kelvin:
                    //(0 K − 273.15) × 9/5 + 32
                    temperature = System.Math.Round((temperature - 273.15) * 1.8 + 32, 2);
                    scale = Scale.Kelvin;
                    break;
                case Scale.Celcius:
                    //(0 °C × 9/5) + 32
                    temperature = System.Math.Round((temperature * 1.8) + 32, 2);
                    scale = Scale.Celcius;
                    break;
                case Scale.Fahrenheit:
                    break;
                default:
                    break;
            }
            return temperature;
        }
        public double ToKelvin()
        {
            switch (scale)
            {
                case Scale.Kelvin:
                    break;
                case Scale.Celcius:
                    //15.5 °C + 273.15
                    temperature = System.Math.Round(temperature + 273.15, 2);
                    scale = Scale.Celcius;
                    break;
                case Scale.Fahrenheit:
                    //(15.5 °F − 32) × 5/9 + 273.15
                    temperature = System.Math.Round(((temperature - 32) * 5/9) + 273.15, 2);
                    scale = Scale.Fahrenheit;
                    break;
                default:
                    break;
            }
            return temperature;
        }
        public double ToCelsius()
        {
            switch (scale)
            {
                case Scale.Kelvin:
                    //15.5 °C + 273.15
                    temperature = System.Math.Round(temperature - 273.15, 2);
                    scale = Scale.Kelvin;
                    break;
                case Scale.Celcius:
                    break;
                case Scale.Fahrenheit:
                    //(15.5 °F − 32) × 5/9
                    temperature = System.Math.Round(((temperature - 32) * 5 / 9), 2);
                    scale = Scale.Fahrenheit;
                    break;
                default:
                    break;
            }
            return temperature;
        }

    }
}
