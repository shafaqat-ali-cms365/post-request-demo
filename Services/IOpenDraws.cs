using Entities.Requests;
using Entities.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public interface IOpenDraws
    {
        Task<OpenDrawResponse> GetOpenDrawsAsync(OpenDrawRequest openDrawRequest);
    }
}