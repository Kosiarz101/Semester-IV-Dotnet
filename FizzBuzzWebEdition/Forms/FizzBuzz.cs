using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzWebEdition.Forms
{
    public class FizzBuzz
    {
        [Display(Name = "Otrzymano")]
        public string Result { get; set; }
        [Display(Name = "Szukana liczba")]
        public int SearchedValue { get; set; }
        [Display(Name = "Data ostatniego wyszukiwania")]
        public DateTime LastSearchDate { get; set; }
        public FizzBuzz()
        {
            Result = "";
        }
        public void Calculate(int searchedValue)
        {
            SearchedValue = searchedValue;
            if (SearchedValue % 3 == 0)
                Result += "Fizz";
            if (SearchedValue % 5 == 0)
                Result += "Buzz";
            LastSearchDate = DateTime.Now;
        }
    }
}
