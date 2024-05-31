using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiValidationError : ApiResponse
    {
        public IEnumerable<string> Errors { get; set; }

        public ApiValidationError() : base(400)
        {
        }
    }
}