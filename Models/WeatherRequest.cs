using Microsoft.Build.Framework;

namespace AplikacjaPogodowa.Models;

public class WeatherRequest
{
    [Required]
    public string City { get; set; }
}