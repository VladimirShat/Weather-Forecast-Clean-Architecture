using Newtonsoft.Json;

namespace Data.Entities
{
    public class Main
    {
        [JsonProperty("temp")]
        public double Temperature { get; set; }
    }
}
