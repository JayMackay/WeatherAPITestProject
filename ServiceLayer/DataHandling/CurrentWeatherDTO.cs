using Newtonsoft.Json;

namespace OpenWeatherAPITestProject.ServiceLayer.DataHandling
{
    public class CurrentWeatherDTO
    {
        //Get current weather root properties
        public CurrentWeatherRootObject CurrentWeather { get; set; }

        //Create an instance of the Current Weather class once a response is passed via the Open Weather API
        public void DeserializeWeather(string CurrentWeatherResponse)
        {
            CurrentWeather = JsonConvert.DeserializeObject<CurrentWeatherRootObject>(CurrentWeatherResponse);
        }
    }
}
