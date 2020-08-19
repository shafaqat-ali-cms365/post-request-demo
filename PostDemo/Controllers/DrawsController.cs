using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Entities.Requests;
using Entities.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace PostDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrawsController : ControllerBase
    {
        private const string requestURL = "https://data.api.thelott.com/sales/vmax/web/data/lotto/opendraws";

        /// <summary>
        /// Posts an OpenDrawRequest request
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /api/draws
        ///     {
        ///        "CompanyId":"GoldenCasket",
        ///        "MaxDrawCount":20,
        ///        "OptionalProductFilter":["TattsLotto","MonWedLotto","OzLotto","MonWedLotto","Powerball","Super66"]
        ///     }
        ///
        /// </remarks>
        /// <param name="openDrawRequest"></param>
        [HttpPost]
        //[SwaggerRequestExample(typeof(OpenDrawRequest), typeof(OpenDrawRequestExample))]
        public async Task<OpenDrawResponse> OpenDrawers([FromBody] OpenDrawRequest openDrawRequest)
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