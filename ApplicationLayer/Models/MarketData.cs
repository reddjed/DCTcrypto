
using Newtonsoft.Json;

namespace ApplicationLayer.Models
{
    public class MarketData
    {
        [JsonProperty("current_price")]
        public Currencies? CurrentPrice { get; set; }

        [JsonProperty("total_volume")]
        public Currencies? TotalVolume { get; set; }

        [JsonProperty("price_change_percentage_24h")]
        public double? PriceChangePercentage24h { get; set; }

        [JsonProperty("price_change_percentage_7d")]
        public double? PriceChangePercentage7d { get; set; }

        [JsonProperty("price_change_percentage_14d")]
        public double? PriceChangePercentage14d { get; set; }

        [JsonProperty("price_change_percentage_30d")]
        public double? PriceChangePercentage30d { get; set; }

        [JsonProperty("price_change_percentage_60d")]
        public double? PriceChangePercentage60d { get; set; }

        [JsonProperty("price_change_percentage_200d")]
        public double? PriceChangePercentage200d { get; set; }

    }

}
