using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Models
{
    public class Coin
    {
        [JsonProperty("coins")]
        public List<CoinItem> Coins { get; set; }

        [JsonProperty("exchanges")]
        public List<Exchange> Exchanges { get; set; }
    }
}