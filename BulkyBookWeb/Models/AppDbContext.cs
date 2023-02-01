﻿using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Category { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=bulkybook;user=root;password=");
        }
    }
}
