using AplikacjaPogodowa.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AplikacjaPogodowa.Controllers;

public class WeatherController : Controller
{
    private HttpClient _weatherClient;
    private const string ApiKey = "71769ffed6c14e43be0181046230807";

    public WeatherController()
    {
        _weatherClient = new HttpClient();
        _weatherClient.BaseAddress = new Uri($"http://api.weatherapi.com");
    }

    [HttpGet]
    public ActionResult WeatherRequest()
    {
        return View();
    }
    
    [HttpGet]
    public ActionResult ForecastRequest()
    {
        return View();
    }

    [Route("[controller]/current")]
    [HttpGet]
    public async Task<ActionResult> GetWeather([FromQuery]string city)
    {
        var responseMessage = await _weatherClient.GetAsync($"/v1/current.json?key={ApiKey}&q={city}&aqi=no");

        var weather = JsonConvert.DeserializeObject<WeatherResponse>(await responseMessage.Content.ReadAsStringAsync());
        
        return View(weather);
    }
    
    [Route("[controller]/forecast")]
    [HttpGet]
    public async Task<ActionResult> GetForecast([FromQuery]string city, [FromQuery] int days)
    {
        var responseMessage = await _weatherClient.GetAsync($"/v1/forecast.json?key={ApiKey}&q={city}&days={days}&aqi=no&alerts=no");

        var weather = JsonConvert.DeserializeObject<ForecastResponse>(await responseMessage.Content.ReadAsStringAsync());
        
        return View(weather);
    }
}