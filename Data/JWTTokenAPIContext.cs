using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JWTTokenAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace JWTTokenAPI.Data
{
    public class JWTTokenAPIContext : IdentityDbContext<ApplicationUser>
    {
        public JWTTokenAPIContext (DbContextOptions<JWTTokenAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Events> Events { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }


    //public DbSet<JWTTokenAPI.Models.Company> Company { get; set; } = default!;
}

