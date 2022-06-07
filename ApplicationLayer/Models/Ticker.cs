using Newtonsoft.Json;

namespace ApplicationLayer.Models
{
    public class Ticker
    {
        [JsonProperty("base")]
        public string? Base { get; set; }

        [JsonProperty("target")]
        public string? Target { get; set; }

        [JsonProperty("market")]
        public Market? Market { get; set; }

        [JsonProperty("volume")]
        public double Volume { get; set; }

        [JsonProperty("trust_score")]
        public string? TrustScore { get; set; }

        [JsonProperty("trade_url")]
        public string? TradeUrl { get; set; }
    }

}