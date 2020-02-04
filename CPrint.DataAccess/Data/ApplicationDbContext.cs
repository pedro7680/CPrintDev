using System;
using System.Collections.Generic;
using System.Text;
using CPrint.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CPrint.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           
    }

        // add category to the db table 
        public DbSet<Category> Categories { get; set; }
    }
}
