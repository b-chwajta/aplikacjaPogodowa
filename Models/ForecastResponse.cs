namespace AplikacjaPogodowa.Models;

public record ForecastResponse(Location Location, Forecast Forecast);

public record Forecast(List<ForecastDay> Forecastday);

public record ForecastDay(string Date, Day Day);

public record Day(decimal Avgtemp_c, decimal Maxwind_kph, decimal Avghumidity, Condition Condition);
