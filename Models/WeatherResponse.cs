namespace AplikacjaPogodowa.Models;

public record WeatherResponse(Location Location, Current Current);

public record Location(string Name, string Tz_id, DateTime LocalTime);

public record Current(decimal Temp_c, Condition Condition, decimal Wind_kph, string Wind_dir,
    decimal Pressure_mb, decimal Feelslike_c, decimal Vis_km);

public record Condition(string Text, string Icon);  