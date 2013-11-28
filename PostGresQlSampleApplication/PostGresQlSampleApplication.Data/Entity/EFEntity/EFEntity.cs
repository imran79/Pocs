using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace PostGresQlSampleApplication.Data.Entity
{
   public class EFEntity: DbContext
    {
       public EFEntity()
            : base("name=SampleEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<WorkProfile> WorkProfiles { get; set; }
        public DbSet<EducationProfile> EducationProfiles { get; set; }
           }
}
