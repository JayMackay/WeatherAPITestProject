using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenWeatherAPITestProject.ServiceLayer.DataHandling;
using OpenWeatherAPITestProject.ServiceLayer.HTTPManager;
using System;

namespace OpenWeatherAPITestProject.ServiceLayer
{
    public class CurrentWeatherService
    {
        //Our instance of the call manager that manages the call to the API to get the data
        public WeatherCallManager weatherCallManager = new WeatherCallManager();

        //Our instance of the DTO that transforms our data into the format of our model
        public CurrentWeatherDTO currentWeatherDTO = new CurrentWeatherDTO();

        //The Weather call of the City requested retrieved
        public String currentCity;

        //Weather converted to JObject so we manipulate later in useful methods
        public JObject json_weather;

        public CurrentWeatherService()
        {
            currentCity = weatherCallManager.GetCurrentWeather();
            currentWeatherDTO.DeserializeWeather(currentCity);
            json_weather = JsonConvert.DeserializeObject<JObject>(currentCity);
        }

        public bool HumidCheck()
        {
            var humidity = currentWeatherDTO.CurrentWeather.main.humidity;
            if (humidity <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
