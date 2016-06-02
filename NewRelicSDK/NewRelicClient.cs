using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public async Task<string> MakeRequest(string url, string method="GET",string payload ="")
        {

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", this._apiKey);
            
            string getResponsestring = "";

            var response = new HttpResponseMessage();

            if (method.Equals("GET"))
            {
                response = await httpClient.GetAsync(NewRelicApiUrl + url);
            }
            if (method.Equals("PUT"))
            {
            

                response = await httpClient.PutAsync(NewRelicApiUrl + url, new StringContent(payload,
                                                    Encoding.UTF8,
                                                    "application/json"));
            }
            
            if (response.IsSuccessStatusCode)
            {
                 getResponsestring = await response.Content.ReadAsStringAsync();
            }
            else
            {
                if (response.StatusCode.Equals(HttpStatusCode.NotFound))
                {

                    throw new System.InvalidOperationException("Result not found");
                }
                else
                {
                    throw new System.InvalidOperationException("Something went wrong.");
                }
            }
            //string response = await httpClient.GetStringAsync(NewRelicApiUrl + url);

            return getResponsestring;

        }
    }
}
