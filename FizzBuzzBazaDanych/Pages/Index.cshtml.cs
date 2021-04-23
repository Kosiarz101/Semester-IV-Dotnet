using FizzBuzzBazaDanych.Data;
using FizzBuzzBazaDanych.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzBazaDanych.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly FizzBuzzContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        [Display(Name = "Podaj Wartość: "), BindProperty]
        [Range(1, 1000, ErrorMessage = "Wartość musi być z przedziału {1}-{2}"), Required(ErrorMessage = "To pole jest wymagane")]
        public int InputValue { get; set; }
        public FizzBuzz CurrentFizzBuzz { get; set; }

        public IndexModel(ILogger<IndexModel> logger, FizzBuzzContext context, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                CurrentFizzBuzz = new FizzBuzz();
                string userId = _userManager.GetUserId(User);
                CurrentFizzBuzz.Calculate(InputValue, userId);
                HttpContext.Session.SetString("SessionFizzBuzz", JsonConvert.SerializeObject(CurrentFizzBuzz));
                _context.FizzBuzzData.Add(CurrentFizzBuzz);
                _context.SaveChangesAsync();
                return Page();
            }
            return Page();
        }
    }
}
