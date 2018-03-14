using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GetApplicantByUC.Models
{
    public class Applicant
    {
        public int appId { get; set; }
        public string appFirstName { get; set; }
        public string appLastName { get; set; }
        public string appStatus { get; set; }
        public DateTime? appBirthdate { get; set; }
        public string appUniqueCode { get; set; }
        public string appResolution { get; set; }
        public string appFilename { get; set; }
        public string appEmail { get; set; }
        public string appImage { get; set; }


        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Applicant>(entity =>
            {
                entity.HasKey(e => e.appId);
            });
       }

    }
}
