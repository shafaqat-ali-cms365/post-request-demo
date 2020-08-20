using Entities.Requests;
using Entities.Responses;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OpenDraws : IOpenDraws
    {
        private const string requestURL = "https://data.api.thelott.com/sales/vmax/web/data/lotto/opendraws";

        public async Task<OpenDrawResponse> GetOpenDrawsAsync(OpenDrawRequest openDrawRequest)
        {
            using (var client = new HttpClient())
            {
                var request = await client.PostAsync(requestURL, new StringContent(JsonConvert.SerializeObject(openDrawRequest), Encoding.UTF8, "application/json"));
                var response = await request.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<OpenDrawResponse>(response);
            }
        }
    }
}