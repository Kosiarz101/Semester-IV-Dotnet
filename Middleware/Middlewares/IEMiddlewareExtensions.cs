using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Middleware.Middlewares
{
    public static class IEMiddlewareExtensions
    {
        public static IApplicationBuilder UseIEMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<IEMiddleware>();
        }
    }
}
