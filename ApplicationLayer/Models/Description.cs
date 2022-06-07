using Newtonsoft.Json;

namespace ApplicationLayer.Models
{
    public class Description
    {
        [JsonProperty("en")]
        public string? En { get; set; }
    }
}