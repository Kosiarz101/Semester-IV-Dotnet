using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wangkanai.Detection.Models;
using Wangkanai.Detection.Services;

namespace Middleware.Middlewares
{
    public class IEMiddleware
    {
        private RequestDelegate _next;
        private StringValues userAgent;

        public IEMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public Task Invoke(HttpContext context, IDetectionService detection)
        {
            if (detection.Browser.Name == Browser.InternetExplorer || detection.Browser.Name == Browser.Edge)
            {
                context.Response.ContentType = "text/plain; charset=utf-8";
                context.Response.WriteAsync("Przeglądarka nie jest obsługiwana");
                return Task.Run(() => { });
            }              
            if(context.Request.Headers.TryGetValue("User-Agent", out userAgent))
            {
                context.Response.WriteAsync(userAgent);
            }           
            return _next(context);
        }
    }
}
