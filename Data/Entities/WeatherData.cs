using System.Collections.Generic;
using Newtonsoft.Json;

namespace Data.Entities
{
    public class WeatherData
    {
        [JsonProperty("coord")]
        public Coord Coord { get; set; }

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("weather")]
        public IList<Weather> WeatherList { get; set; }
    }
}
