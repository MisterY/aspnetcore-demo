using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmearerMiddleware
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseSmearer(this IApplicationBuilder builder,
            SmearerOptions options)
        {
            var smearer = builder.ApplicationServices
                .GetService(typeof(Smearer)) as Smearer;
            return builder.Use(next => new Middleware(next, options, smearer).Invoke);
        }
    }
}
