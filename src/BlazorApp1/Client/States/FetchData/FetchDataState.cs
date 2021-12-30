using Fluxor;
using BlazorApp1.Shared;

namespace BlazorApp1.Client.States.FetchData;

[FeatureState]
public record FetchDataState(IEnumerable<WeatherForecast> Forecasts)
{
    private FetchDataState() : this(Array.Empty<WeatherForecast>()) { }

    
}

public record GetWeahterForecastAction;


