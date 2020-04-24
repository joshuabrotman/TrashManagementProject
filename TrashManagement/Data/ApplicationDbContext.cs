using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrashManagement.Models;

namespace TrashManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Customer", NormalizedName = "CUSTOMER" });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Employee", NormalizedName = "EMPLOYEE" });
        }

        public DbSet<TrashManagement.Models.Customer> Customer { get; set; }

        public DbSet<TrashManagement.Models.Employee> Employee { get; set; }

        public DbSet<TrashManagement.Models.Address> Address { get; set; }

        public DbSet<TrashManagement.Models.Pickup> Pickup { get; set; }

        public DbSet<TrashManagement.Models.Suspend> Suspend { get; set; }
    }
}
