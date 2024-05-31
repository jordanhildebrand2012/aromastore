using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiException : ApiResponse
    {
        public string Detail { get; set; }
        public ApiException(int statusCode, string message = null, string detail = null)
            : base(statusCode, message)
        {
            Detail = detail;
        }
    }
}