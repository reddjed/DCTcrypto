using Newtonsoft.Json;

namespace ApplicationLayer.Models
{
    public class SearchCoins
    {
        [JsonProperty("coins")]
        public List<CoinBySearch> Coins { get; set; }
    }
}
