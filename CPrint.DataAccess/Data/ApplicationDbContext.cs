using System;
using System.Collections.Generic;
using System.Text;
using CPrint.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CPrint.DataAccess.Data
{
    // using identityDbContext to all users and logins. 
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           
    }

        // add category to the db table 
        // all futher tables are added as dbsets. 
        public DbSet<Category> Categories { get; set; }
    }
}
