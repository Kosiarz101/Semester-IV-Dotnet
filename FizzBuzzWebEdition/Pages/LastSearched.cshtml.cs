using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using FizzBuzzWebEdition.Forms;
using Newtonsoft.Json;

namespace FizzBuzzWebEdition.Pages
{
    public class LastSearchedModel : PageModel
    {
        public FizzBuzz CurrentFizzBuzz { get; set; }
        public void OnGet()
        {
            var SessionInputValue = HttpContext.Session.GetString("SessionFizzBuzz");
            if (SessionInputValue != null)
                CurrentFizzBuzz = JsonConvert.DeserializeObject<FizzBuzz>(SessionInputValue);
        }

    }
}
