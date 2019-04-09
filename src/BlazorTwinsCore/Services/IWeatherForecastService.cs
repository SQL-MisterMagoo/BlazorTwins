using System;
using System.Threading.Tasks;

namespace BlazorTwinsCore.Services
{
    public interface IWeatherForecastService
    {

        Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
    }
}
