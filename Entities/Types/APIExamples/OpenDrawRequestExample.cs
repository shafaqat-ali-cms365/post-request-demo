using Entities.Requests;
using Swashbuckle.AspNetCore.Examples;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Types.APIExamples
{
    public class OpenDrawRequestExample : IExamplesProvider
    {
        public object GetExamples()
        {
            return new OpenDrawRequest()
            {
                CompanyId = "GoldenCasket",
                MaxDrawCount = 20,
                OptionalProductFilter = new string[] { "TattsLotto", "MonWedLotto", "OzLotto", "MonWedLotto", "Powerball", "Super66" }
            };
        }
    }
}