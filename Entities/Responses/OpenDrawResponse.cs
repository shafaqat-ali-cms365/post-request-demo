using Entities.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Responses
{
    public class OpenDrawResponse
    {
        public Draw[] Draws { get; set; }
        public ErrorInfo ErrorInfo { get; set; }
        public bool Success { get; set; }
    }
}