using FizzBuzzBazaDanych.Forms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzBazaDanych.Data
{
    public class FizzBuzzContext : DbContext
    {
        public DbSet<FizzBuzz> FizzBuzzData { get; set; }
        public FizzBuzzContext(DbContextOptions options) : base(options) { } 
    }
}
