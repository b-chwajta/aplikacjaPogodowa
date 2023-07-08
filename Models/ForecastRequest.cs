using Microsoft.Build.Framework;

namespace AplikacjaPogodowa.Models;

public class ForecastRequest
{
    [Required]
    public string City { get; set; }
    [Required]
    public int Days { get; set; }
}