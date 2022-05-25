using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassTemperatures;

namespace UnitTestTemperatures
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCelsiusToFahrenheit()
        {
            temperatures temperatures = new temperatures(15.0, Scale.Celsius);
            Assert.AreEqual(59, temperatures.ToFarenheit());
        }
        [TestMethod]
        public void TestKelvinToFahrenheit()
        {
            temperatures temperatures = new temperatures(15.0, Scale.kelvin);
            Assert.AreEqual(-432.67, temperatures.ToFarenheit());
        }
        [TestMethod]
        public void TestFahrenheitToFahrenheit()
        {
            temperatures temperatures = new temperatures(15.0, Scale.Fahrenheit);
            Assert.AreEqual(15, temperatures.ToFarenheit());
        }
        [TestMethod]
        public void TestCelsiusToKelvin()
        {
            temperatures temperatures = new temperatures(15.0, Scale.Celsius);
            Assert.AreEqual(288.15, temperatures.ToKelvin());
        }
        [TestMethod]
        public void TestKelvinToKelvin()
        {
            temperatures temperatures = new temperatures(15.0, Scale.kelvin);
            Assert.AreEqual(15, temperatures.ToKelvin());
        }
        [TestMethod]
        public void TestFahrenheitToKelvin()
        {
            temperatures temperatures = new temperatures(15.0, Scale.Fahrenheit);
            Assert.AreEqual(263.71, temperatures.ToKelvin());
        }
        [TestMethod]
        public void TestCelsiusToCelsius()
        {
            temperatures temperatures = new temperatures(15.0, Scale.Celsius);
            Assert.AreEqual(15, temperatures.ToCelsius());
        }
        [TestMethod]
        public void TestKelvinToCelsius()
        {
            temperatures temperatures = new temperatures(15.0, Scale.kelvin);
            Assert.AreEqual(-258.15, temperatures.ToCelsius());
        }
        [TestMethod]
        public void TestFahrenheitToCelsius()
        {
            temperatures temperatures = new temperatures(15.0, Scale.Fahrenheit);
            Assert.AreEqual(-9.44, temperatures.ToCelsius());
        }
        [TestMethod]
        public void TestAddFahrenheitWhithCelsius()
        {
            temperatures temperatures = new temperatures(15.0, Scale.Fahrenheit);
            temperatures temperatures_b = new temperatures(20.0, Scale.Celsius);
            double g = temperatures.Add(temperatures_b);
            Assert.AreEqual(83, g);
        }
    }
}
