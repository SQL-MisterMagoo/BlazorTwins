using System;
using System.Threading.Tasks;

namespace Blazor.Twins.Core.Services
{
    public interface IWeatherForecastService
    {

        Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
    }
}
