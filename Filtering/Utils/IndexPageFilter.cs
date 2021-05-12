using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filtering.Utils
{
    public class IndexPageFilter : ResultFilterAttribute
    {        
        public async override Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            var result = context.Result;
            if (result is PageResult)
            {
                var page = ((PageResult)result);
                page.ViewData["IPAddress"] += context.HttpContext.Connection.RemoteIpAddress.ToString();
            }
            await next.Invoke();
        }
    }
}
