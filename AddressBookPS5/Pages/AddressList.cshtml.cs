using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using AddressBookPS5.Forms;

namespace AddressBookPS5.Pages
{
    public class AddressListModel : PageModel
    {
        public Address Address { get; set; }
        public void OnGet()
        {
            var SessionAddress = HttpContext.Session.GetString("SessionAddress");
            if (SessionAddress != null)
                Address = JsonConvert.DeserializeObject<Address>(SessionAddress);
        }
    }
}
