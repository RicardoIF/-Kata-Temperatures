using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassTemp;

namespace UnitTestTemperatures
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFahrenheitToFahrenheit()
        {
            ClassTemperatures temp = new ClassTemperatures(15.5, Scale.Fahrenheit);
            Assert.AreEqual(15.5, temp.ToFahrenheit());
        }
        [TestMethod]
        public void TestCelsiusToFahrenheit()
        {
            ClassTemperatures temp = new ClassTemperatures(15.5, Scale.Celcius);
            Assert.AreEqual(59.9, temp.ToFahrenheit());
        }
        [TestMethod]
        public void TestKelvinToFahrenheit()
        {
            ClassTemperatures temp = new ClassTemperatures(15.5, Scale.Kelvin);
            Assert.AreEqual(-431.77, temp.ToFahrenheit());
        }
        [TestMethod]
        public void TestFahrenheitToKelvin()
        {
            ClassTemperatures temp = new ClassTemperatures(15.5, Scale.Fahrenheit);
            Assert.AreEqual(263.98, temp.ToKelvin());
        }
        [TestMethod]
        public void TestCelsiusToKelvin()
        {
            ClassTemperatures temp = new ClassTemperatures(15.5, Scale.Celcius);
            Assert.AreEqual(288.65, temp.ToKelvin());
        }
        [TestMethod]
        public void TestKelvinToKelvin()
        {
            ClassTemperatures temp = new ClassTemperatures(15.5, Scale.Kelvin);
            Assert.AreEqual(15.5, temp.ToKelvin());
        }
        [TestMethod]
        public void TestFahrenheitToCelsius()
        {
            ClassTemperatures temp = new ClassTemperatures(15.5, Scale.Fahrenheit);
            Assert.AreEqual(-9.17, temp.ToCelsius());
        }
        [TestMethod]
        public void TestCelsiusToCelsius()
        {
            ClassTemperatures temp = new ClassTemperatures(15.5, Scale.Celcius);
            Assert.AreEqual(15.5, temp.ToCelsius());
        }
        [TestMethod]
        public void TestKelvinToCelsius()
        {
            ClassTemperatures temp = new ClassTemperatures(15.5, Scale.Kelvin);
            Assert.AreEqual(-257.65, temp.ToCelsius());
        }
    }
}
