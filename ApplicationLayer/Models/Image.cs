using Newtonsoft.Json;

namespace ApplicationLayer.Models
{
    public class Image
    {
        [JsonProperty("thumb")]
        public string? Thumb { get; set; }

        [JsonProperty("small")]
        public string? Small { get; set; }

        [JsonProperty("large")]
        public string? Large { get; set; }
    }
}