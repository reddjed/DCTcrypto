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

                var res = Response<Coin>.Success(JsonConvert.DeserializeObject<Coin>(response));

                return res;
            }
            catch (Exception)
            {
                return Response<Coin>.Error("Error get trending");
            }
        }
        public async Task<Response<CurrencyById>> GetCoinById(string coinId)
        {
            try
            {
                var response = await _httpClient.GetStringAsync(_baseUrl + "coins/" + coinId + "?localization=false&tickers=true&market_data=true&community_data=false&developer_data=false&sparkline=false") ;

                var res = Response<CurrencyById>.Success(JsonConvert.DeserializeObject<CurrencyById>(response));

                return res;
            }
            catch (Exception)
            {
                return Response<CurrencyById>.Error("Error get coin by id");
            }
        }
        public async Task<Response<SearchCoins>> SearchCoins(string query)
        {
            try
            {
                var response = await _httpClient.GetStringAsync(_baseUrl + "search?query=" + query);

                var res = Response<SearchCoins>.Success(JsonConvert.DeserializeObject<SearchCoins>(response));

                return res;
            }
            catch (Exception)
            {
                return Response<SearchCoins>.Error("Error searching by query");
            }
        }
    }
}
