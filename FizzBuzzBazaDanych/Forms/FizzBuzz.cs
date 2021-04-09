using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzBazaDanych.Forms
{
    public class FizzBuzz
    {      
        public int Id { get; set; }
        [Display(Name = "Otrzymano")]
        [Column(TypeName = "varchar(20)")]
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
