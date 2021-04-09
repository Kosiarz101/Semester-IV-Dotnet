using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzzBazaDanych.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FizzBuzzBazaDanych.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly FizzBuzzBazaDanych.Data.FizzBuzzContext _context;

        public DeleteModel(FizzBuzzBazaDanych.Data.FizzBuzzContext context)
        {
            _context = context;
        }

        [BindProperty]
        public FizzBuzz FizzBuzz { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FizzBuzz = await _context.FizzBuzzData.FirstOrDefaultAsync(m => m.Id == id);

            if (FizzBuzz == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FizzBuzz = await _context.FizzBuzzData.FindAsync(id);

            if (FizzBuzz != null)
            {
                _context.FizzBuzzData.Remove(FizzBuzz);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

