using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SmearerMiddleware
{
    /// <summary>
    /// Middleware implementation of the Smearer functionality.
    /// </summary>
    public class Middleware
    {
        public Middleware(RequestDelegate next, SmearerOptions options, Smearer smearer)
        {
            this.next = next;
            this.smearer = smearer;
        }

        private RequestDelegate next;
        private Smearer smearer;

        public async Task Invoke(HttpContext context)
        {
            await next.Invoke(context);

            // get the output and smear it
            await context.Response.WriteAsync(
                smearer.Garble(context.Response.Body.ToString())
            );
        }
    }
}
