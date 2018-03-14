using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GetApplicantByUC.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        { }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
            { }

        public DbSet<Applicant> Applicants { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Applicant.OnModelCreating(modelBuilder);

        }
    }
}