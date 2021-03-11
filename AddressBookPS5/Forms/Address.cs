using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBookPS5.Forms
{
    public class Address
    {
        [Display(Name = "Twoja Ulubiona Ulica")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Pole {0} musi zawierać conajmniej {2} znaków oraz nie więcej niż {1} znaków"), Required(ErrorMessage ="Pole jest obowiązkowe")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        public int Number { get; set; }
        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "Pole jest obowiązkowe")]
        public string City { get; set; }
    }
}
