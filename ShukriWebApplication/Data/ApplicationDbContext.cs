using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShukriWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShukriWebApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Schedule> Applicants { get; set; }
        public virtual DbSet<Booking> Experiences { get; set; }
    }
}
