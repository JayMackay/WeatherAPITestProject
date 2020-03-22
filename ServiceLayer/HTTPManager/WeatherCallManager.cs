using RestSharp;

namespace OpenWeatherAPITestProject.ServiceLayer.HTTPManager
{
    public class WeatherCallManager
    {
        private readonly IRestClient client;

        public WeatherCallManager()
        {
            client = new RestClient(AppConfigReader.BaseUrl);
        }

        public string GetCurrentWeather()
        {
            //Weather API Request 
            var request = new RestRequest("weather?q=London&appid=" + AppConfigReader.ApiKey);
            var response = client.Execute(request, Method.GET);
            return response.Content;
        }
    }
}
