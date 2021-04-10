using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjection.Data;
using DependencyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DependencyInjection.Pages
{
    public class SourcedFromDatabaseModel : PageModel
    {
        private readonly ProductContext _context;
        public IList<Product> Products { get; set; }
        public SourcedFromDatabaseModel(ProductContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            Products = _context.Product.ToList();
        }
    }
}
