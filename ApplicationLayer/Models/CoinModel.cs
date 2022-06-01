using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Models
{
    public class CoinModel
    {
        [JsonProperty("coins")]
        public List<ItemModel> Coins { get; set; }

        [JsonProperty("exchanges")]
        public List<ExchangeModel> Exchanges { get; set; }
    }
