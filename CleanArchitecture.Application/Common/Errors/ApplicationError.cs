using CleanArchTemp.Domain.Common.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchTemp.Application.Common.Errors
{
    public static class ApplicationErrors
    {      

        //Your Expected Error in Your Application Can Write here as a layer decripe it 
        //Example
        public static readonly Error TokenGenerationFailed = Error.Failure(
            code: "Auth.TokenGeneration.Failed",
            description: "Failed to generate new JWT token.");

      
    }
}
