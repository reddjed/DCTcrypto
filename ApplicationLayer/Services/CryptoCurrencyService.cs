using ApplicationLayer.Models;
using Newtonsoft.Json;
using System.Reflection;
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
            _httpClient.BaseAddress = _baseUrl;
        }
        public async Task<Response<Coin>> GetTranding()
        {
            try
            {
                var response = await _httpClient.GetStringAsync(_httpClient.BaseAddress + "search/trending");

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
                var response = await _httpClient.GetStringAsync(_httpClient.BaseAddress + "coins/" + coinId + "?localization=false&tickers=true&market_data=true&community_data=false&developer_data=false&sparkline=false");

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
                var response = await _httpClient.GetStringAsync(_httpClient.BaseAddress + "search?query=" + query);

                var res = Response<SearchCoins>.Success(JsonConvert.DeserializeObject<SearchCoins>(response));

                return res;
            }
            catch (Exception)
            {
                return Response<SearchCoins>.Error("Error searching by query");
            }
        }
        //public double? ConvertCurrencies(double quantity, string currencyFromId, string currencyToId, string resultCurrency)
        //{
        //    try
        //    {
        //        var from = GetCoinById(currencyFromId).Result.Data.MarketData.CurrentPrice;

        //        var fromProp = Currencies.GetPropValue(from, nameof(resultCurrency));

        //        var to = GetCoinById(currencyToId).Result.Data.MarketData.CurrentPrice;

        //        var toProp = Currencies.GetPropValue(to, nameof(resultCurrency));

        //        var exchangeRate = (double)toProp / (double)fromProp;

        //        var res = quantity * exchangeRate;

        //        return res;


        //    }
        //    catch (Exception ex)
        //    {
               
        //        return null;
        //    }
        //}

    }
}
