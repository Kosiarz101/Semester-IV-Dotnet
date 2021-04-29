using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzzBazaDanych.Data;
using FizzBuzzBazaDanych.Forms;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizzBuzzBazaDanych.Pages
{
    [Authorize]
    public class LastSearchedDatabaseModel : PageModel
    {
        private readonly FizzBuzzContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public IList<FizzBuzz> FizzBuzzEntries { get; set; }
        public LastSearchedDatabaseModel(FizzBuzzContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public void OnGet()
        {
            var FizzBuzzQuery = (from FizzBuzzData in _context.FizzBuzzData
                                orderby FizzBuzzData.LastSearchDate descending
                                select FizzBuzzData).Take(20);
            FizzBuzzEntries = FizzBuzzQuery.ToList();
        }
        public void OnGetUserList()
        {
            string userId = _userManager.GetUserId(User);
            var FizzBuzzQuery = (from FizzBuzzData in _context.FizzBuzzData
                                 where FizzBuzzData.Creator == userId
                                 orderby FizzBuzzData.LastSearchDate descending
                                 select FizzBuzzData).Take(20);
            FizzBuzzEntries = FizzBuzzQuery.ToList();
        }
    }
}
