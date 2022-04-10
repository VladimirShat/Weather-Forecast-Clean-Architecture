using Data.Entities;
using Domain.Entities;
using Domain.Mappers;

namespace Data.Mappers
{
    public class WeatherDataEntityMapper: IMapper<WeatherData, WeatherEntity>
    {
        public WeatherEntity MapFrom(WeatherData weatherData)
        {
            if (weatherData == null)
            {
                throw new System.ArgumentNullException(nameof(weatherData));
            }

            return new WeatherEntity
            {
                Lon = weatherData.Coord.Lon,
                Lat = weatherData.Coord.Lat,
                Temperature = weatherData.Main.Temperature,
                Description = weatherData.WeatherList[0].Description
            };
        }
    }
}
