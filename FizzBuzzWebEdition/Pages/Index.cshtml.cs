using FizzBuzzWebEdition.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzWebEdition.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [Display(Name = "Podaj Wartość: "), BindProperty]
        [Range(1, 1000, ErrorMessage = "Wartość musi być z przedziału {1}-{2}"), Required(ErrorMessage = "To pole jest wymagane")]
        public int InputValue { get; set; }
        public FizzBuzz CurrentFizzBuzz { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                CurrentFizzBuzz = new FizzBuzz();
                CurrentFizzBuzz.Calculate(InputValue);
                HttpContext.Session.SetString("SessionFizzBuzz", JsonConvert.SerializeObject(CurrentFizzBuzz));
                return Page();
            }
            return Page();
        }
    }
}
