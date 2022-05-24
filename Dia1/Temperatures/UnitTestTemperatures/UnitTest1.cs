using Microsoft.VisualStudio.TestTools.UnitTesting;
using Temperatures;

namespace UnitTestTemperatures
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestKelvinToFahrenheit()
        {
            ClassTemp classTemp = new ClassTemp(15.5, TemperatureScale.Kelvin);
            double result = classTemp.ToFahrenheit();
            Assert.AreEqual(-431.77, result);
        }
        [TestMethod]
        public void TestCelsiusToFahrenheit()
        {
            ClassTemp classTemp = new ClassTemp(15.5, TemperatureScale.Celsius);
            double result = classTemp.ToFahrenheit();
            Assert.AreEqual(59.900000000000006, result);
        }
        [TestMethod]
        public void TestFahrenheitToFahrenheit()
        {
            ClassTemp classTemp = new ClassTemp(10.0, TemperatureScale.Fahrenheit);
            double result = classTemp.ToFahrenheit();
            Assert.AreEqual(10.0, result);
        }
        [TestMethod]
        public void TestKelvinToCelsius()
        {
            ClassTemp classTemp = new ClassTemp(15.5, TemperatureScale.Kelvin);
            double result = classTemp.ToCelsius();
            Assert.AreEqual(-257.65, result);
        }
        [TestMethod]
        public void TestCelsiusToCelsius()
        {
            ClassTemp classTemp = new ClassTemp(15.5, TemperatureScale.Celsius);
            double result = classTemp.ToCelsius();
            Assert.AreEqual(15.5, result);
        }
        [TestMethod]
        public void TestFahrenheitToCelsius()
        {
            ClassTemp classTemp = new ClassTemp(15.5, TemperatureScale.Fahrenheit);
            double result = classTemp.ToCelsius();
            Assert.AreEqual(-9.167399999999999, result);
        }
    }
}
