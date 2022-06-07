using Newtonsoft.Json;

namespace ApplicationLayer.Models
{
    public class CurrencyById
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("symbol")]
        public string? Symbol { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("image")]
        public Image? Image { get; set; }

        [JsonProperty("description")]
        public Description? Description { get; set; }

        [JsonProperty("market_data")]
        public MarketData? MarketData { get; set; }

        [JsonProperty("tickers")]
        public List<Ticker>? Tickers { get; set; }
    }
}
