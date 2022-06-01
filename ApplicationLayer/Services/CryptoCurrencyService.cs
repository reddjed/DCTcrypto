using ApplicationLayer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Services
{
    public class CryptoCurrencyService
    {
        private readonly Uri _baseUrl = new Uri("https://api.coingecko.com/api/v3/");
        private readonly HttpClient _httpClient;

        public CryptoCurrencyService()
        {
            _httpClient = new HttpClient();
        }
        public async Task<ResponseModel<CoinModel>> GetTranding()
        {
            try
            {
                var response = await _httpClient.GetStringAsync(_baseUrl + "search/trending");

                if (String.IsNullOrEmpty(response)) return ResponseModel<CoinModel>.Error("Error Get trending");

                return ResponseModel<CoinModel>.Success(JsonConvert.DeserializeObject<CoinModel>(response));
            }
            catch (Exception)
            {
                return ResponseModel<CoinModel>.Error("Error Get trending");
            }
        }

    }
}
