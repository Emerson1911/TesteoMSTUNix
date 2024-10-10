namespace ENAE.Temperatura.UnitTestMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]
        public void CelsiusToFahrenheitTest()
        {
            ENAETemperatura calculator = new ENAETemperatura();

            double result = calculator.CelsiusToFahrenheit(0);

            Assert.AreEqual(32, result);
        }

        [TestMethod()]
        public void FahrenheitToCelsiusTest()
        {
            ENAETemperatura calculator = new ENAETemperatura();

            double result = calculator.FahrenheitToCelsius(32);

            Assert.AreEqual(0, result);
        }

        [TestMethod()]
        public void CelsiusToFahrenheitTest_Positive()
        {
            ENAETemperatura calculator = new ENAETemperatura();

            double result = calculator.CelsiusToFahrenheit(100);

            Assert.AreEqual(212, result);
        }

        [TestMethod()]
        public void FahrenheitToCelsiusTest_Positive()
        {
            ENAETemperatura calculator = new ENAETemperatura();

            double result = calculator.FahrenheitToCelsius(212);

            Assert.AreEqual(100, result);
        }

        [TestMethod()]
        public void CelsiusToFahrenheitTest_Negative()
        {
            ENAETemperatura calculator = new ENAETemperatura();

            double result = calculator.CelsiusToFahrenheit(-40);

            Assert.AreEqual(-40, result);
        }

        [TestMethod()]
        public void FahrenheitToCelsiusTest_Negative()
        {
            ENAETemperatura calculator = new ENAETemperatura();

            double result = calculator.FahrenheitToCelsius(-40);

            Assert.AreEqual(-40, result);
        }
    }
}