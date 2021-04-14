using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CeeLearnAndDo_WijOnt.Models;

namespace CeeLearnAndDo_WijOnt.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CeeLearnAndDo_WijOnt.Models.FaQ> FaQ { get; set; }
    }
}
