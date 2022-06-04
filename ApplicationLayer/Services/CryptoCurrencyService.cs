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
        public async Task<Response<Coin>> GetTranding()
        {
            try
            {
                var response = await _httpClient.GetStringAsync(_baseUrl + "search/trending");

                if (String.IsNullOrEmpty(response)) return Response<Coin>.Error("Error Get trending");

                return Response<Coin>.Success(JsonConvert.DeserializeObject<Coin>(response));
            }
            catch (Exception)
            {
                return Response<Coin>.Error("Error Get trending");
            }
        }
        /*	Page with the ability to view detailed information about the currency:
          price, volume, price change, in which markets it can be purchased and at what price(the ability to go to the currency page on the market is a plus). */
        public async Task<Response> GetDetailed(string coinId)
        {

        }
    }
}
