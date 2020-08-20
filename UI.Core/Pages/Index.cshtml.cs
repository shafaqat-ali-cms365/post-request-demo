using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Responses;
using Entities.Types;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Services;

namespace UI.Core.Pages
{
    public class IndexModel : PageModel
    {
        private const string requestURL = "https://data.api.thelott.com/sales/vmax/web/data/lotto/opendraws";
        private readonly ILogger<IndexModel> _logger;
        private IOpenDraws _openDraws;

        public IndexModel(ILogger<IndexModel> logger, IOpenDraws openDraws)
        {
            _logger = logger;
            _openDraws = openDraws;
        }

        public Draw[] Draws { get; set; }

        public async Task OnGet()
        {
            var openDraws = await _openDraws.GetOpenDrawsAsync(new Entities.Requests.OpenDrawRequest()
            {
                CompanyId = "GoldenCasket",
                MaxDrawCount = 20,
                OptionalProductFilter = new string[] { "TattsLotto", "MonWedLotto", "OzLotto", "MonWedLotto", "Powerball", "Super66" }
            }
            );
            Draws = openDraws.Draws;
        }
    }
}