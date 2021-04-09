using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzzBazaDanych.Data;
using FizzBuzzBazaDanych.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizzBuzzBazaDanych.Pages
{
    public class LastSearchedDatabaseModel : PageModel
    {
        private readonly FizzBuzzContext _context;
        public IList<FizzBuzz> FizzBuzzEntries { get; set; }
        public LastSearchedDatabaseModel(FizzBuzzContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            var FizzBuzzQuery = (from FizzBuzzData in _context.FizzBuzzData
                                orderby FizzBuzzData.LastSearchDate descending
                                select FizzBuzzData).Take(10);
            FizzBuzzEntries = FizzBuzzQuery.ToList();
        }      
    }
}
