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

        [Test]
        public void CurrentCity()
        {
            Assert.AreEqual("London", currentWeather.currentWeatherDTO.CurrentWeather.name);
        }

        [Test]
        public void CurrentCountry()
        {
            Assert.AreEqual("GB", currentWeather.currentWeatherDTO.CurrentWeather.sys.country);
        }

        [Test]
        public void HumidtyCheck()
        {
            CurrentWeatherService cws = new CurrentWeatherService();
            var result = cws.HumidCheck();
            Assert.That(result);
        }

        [Test]
        public void TimeZoneCheck()
        {
            Assert.AreEqual(0, currentWeather.currentWeatherDTO.CurrentWeather.timezone);
        }

        [Test]
        public void LatitudeCheck()
        {
            Assert.AreEqual(51.51f, currentWeather.currentWeatherDTO.CurrentWeather.coord.lat);
        }

        [Test]
        public void LongititudeCheck()
        {
            Assert.AreEqual(-0.13f, currentWeather.currentWeatherDTO.CurrentWeather.coord.lon);
        }

        [Test]
        public void WindSpeedCheck()
        {
            Assert.AreEqual(6.2f, currentWeather.currentWeatherDTO.CurrentWeather.wind.speed);
        }

        [Test]
        public void WebCallFailDueToIncorrectCity()
        {
            CurrentWeatherService cw = new CurrentWeatherService();
            var currentW = cw.weatherCallManager.GetCurrentWeather();
            var expected = currentW.ToString();
            Assert.AreEqual(expected, currentW);
        }

        [Test]
        public void IdCheck()
        {
            Assert.AreEqual(2643743, currentWeather.currentWeatherDTO.CurrentWeather.id);
        }
    }
}