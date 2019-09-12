using Microsoft.AspNetCore.Builder;
using PettyCash.API.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PettyCash.API.Extensions
{
    public static class ErrorLoggingMiddlewareExtensions
    {
        public static void UseErrorLogging(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(err => err.Run(ErrorLogging.HandleAsync));
        }
    }
}
