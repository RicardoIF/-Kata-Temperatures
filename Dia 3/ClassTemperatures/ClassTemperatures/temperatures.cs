using System;

namespace ClassTemperatures
{
    public enum Scale{kelvin, Celsius, Fahrenheit};
    public class temperatures
    {
        private double Temp;
        private Scale Scale;
        public temperatures(double Temp, Scale Scale)
        {
            this.Temp = Temp;
            this.Scale = Scale;
        }
        public double Add(temperatures temperatures)
        {
            double result = 0;
            switch (Scale)
            {
                case Scale.Fahrenheit:
                    switch (temperatures.Scale)
                    {
                        case Scale.kelvin:
                            temperatures.ToFarenheit();
                            result = Temp + temperatures.Temp;
                            temperatures.Scale = Scale.kelvin;
                            break;
                        case Scale.Celsius:
                            temperatures.ToFarenheit();
                            result = Temp + temperatures.Temp;
                            temperatures.Scale = Scale.Celsius;
                            break;
                        case Scale.Fahrenheit:
                            result = Temp + temperatures.Temp;
                            break;
                        default:
                            break;
                    }
                    break;
                case Scale.kelvin:
                    switch (temperatures.Scale)
                    {
                        case Scale.kelvin:
                            result = Temp + temperatures.Temp;
                            break;
                        case Scale.Celsius:
                            temperatures.ToKelvin();
                            result = Temp + temperatures.Temp;
                            temperatures.Scale = Scale.Celsius;
                            break;
                        case Scale.Fahrenheit:
                            temperatures.ToKelvin();
                            result = Temp + temperatures.Temp;
                            temperatures.Scale = Scale.Fahrenheit;
                            break;
                        default:
                            break;
                    }
                    break;
                case Scale.Celsius:
                    switch (temperatures.Scale)
                    {
                        case Scale.kelvin:
                            temperatures.ToCelsius();
                            result = Temp + temperatures.Temp;
                            temperatures.Scale = Scale.kelvin;
                            break;
                        case Scale.Celsius:
                            result = Temp + temperatures.Temp;
                            break;
                        case Scale.Fahrenheit:
                            temperatures.ToCelsius();
                            result = Temp + temperatures.Temp;
                            temperatures.Scale = Scale.Fahrenheit;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
        public double ToFarenheit()
        {
            switch (Scale)
            {
                case Scale.kelvin:
                    Temp = Math.Round((Temp - 273.15) * 9 / 5 + 32, 2);
                    Scale = Scale.Fahrenheit;
                    break;
                case Scale.Celsius:
                    Temp = Math.Round((Temp * 9 / 5) + 32, 2);
                    Scale = Scale.Fahrenheit;
                    break;
                case Scale.Fahrenheit:
                    break;
                default:
                    break;
            }
            return Temp;
        }
        public double ToKelvin()
        {
            switch (Scale)
            {
                case Scale.Fahrenheit:
                    Temp = Math.Round((Temp - 32)* 5/9 + 273.15, 2);
                    Scale = Scale.kelvin;
                    break;
                case Scale.Celsius:
                    Temp = Math.Round(Temp + 273.15, 2);
                    Scale = Scale.kelvin;
                    break;
                case Scale.kelvin:
                    break;
                default:
                    break;
            }
            return Temp;
        }
        public double ToCelsius()
        {
            switch (Scale)
            {
                case Scale.Fahrenheit:
                    Temp = Math.Round((Temp - 32)* 5/9 , 2);
                    Scale = Scale.Celsius;
                    break;
                case Scale.kelvin:
                    Temp = Math.Round(Temp - 273.15, 2);
                    Scale = Scale.Celsius;
                    break;
                case Scale.Celsius:
                    break;
                default:
                    break;
            }
            return Temp;
        }
    }
}
