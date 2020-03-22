using NUnit.Framework;
using OpenWeatherAPITestProject.ServiceLayer;

namespace OpenWeatherAPITestProject
{
    [TestFixture]
    public class WeatherRequestTests
    {
        private CurrentWeatherService currentWeather = new CurrentWeatherService();

        [Test]
        public void WebCallSuccessCheck()
        {
            //Check API request connection to confirm that the test framework is successfully built
            Assert.AreEqual(200, currentWeather.currentWeatherDTO.CurrentWeather.cod);
        }

    }
}