using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Requests
{
    public class OpenDrawRequest
    {
        public string CompanyId { get; set; }
        public int MaxDrawCount { get; set; }
        public string[] OptionalProductFilter { get; set; }
    }
}