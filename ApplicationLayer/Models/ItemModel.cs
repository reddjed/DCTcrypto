using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Models
{
    public class ItemModel
    {
        [JsonProperty("item")]
        public CurrencyModel Item { get; set; }
    }
}
