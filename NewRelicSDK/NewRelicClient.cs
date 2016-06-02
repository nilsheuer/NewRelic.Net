using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NewRelicSDK
{
    public partial class NewRelicClient
    {
        private string _apiKey { get; set; }
        private const string NewRelicApiUrl = "https://api.newrelic.com/v2/";

        public NewRelicClient(string apiKey)
        {
            this._apiKey = apiKey;

        }

        public async Task<string> MakeRequest(string url)
        {

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", this._apiKey);
            string response = await httpClient.GetStringAsync(NewRelicApiUrl + url);

            return response;

        }
    }
}
