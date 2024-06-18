using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WomDataInteractor.Services
{
    public class HttpRequestHelper
    {
        public HttpClient Client = new HttpClient();
        private readonly string Endpoint = "https://api.wiseoldman.net/v2";
        private readonly long PoundId = 3576;
        public async Task<T?> MakePostRequestAsync<T>(string url, string data = "") where T : new()
        {
            var obj = new T();
            var uri = new Uri($"{Endpoint}/{url}");
            var content = new StringContent(data, Encoding.UTF8);
            var response = await Client.PostAsync(uri, content);
            var json = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode && string.IsNullOrEmpty(json) == false)
            {
                obj = JsonConvert.DeserializeObject<T>(json);
            }
            return obj;
        }
        public async Task<T?> MakeGetRequestAsync<T>(string url, string data = "") where T : new()
        {
            var obj = new T();
            var uri = new Uri($"{Endpoint}/{url}");
            var content = new StringContent(data, Encoding.UTF8);
            var response = await Client.GetAsync(uri);
            var json = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode && string.IsNullOrEmpty(json) == false)
            {
                obj = JsonConvert.DeserializeObject<T>(json);
            }
            return obj;
        }
    }
}
