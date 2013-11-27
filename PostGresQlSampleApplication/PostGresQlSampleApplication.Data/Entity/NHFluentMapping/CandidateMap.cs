using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace PostGresQlSampleApplication.Data
{
    public class CandidateMap : ClassMap<Candidate>
    {
        public CandidateMap()
        {
            //Schema("test");
            Table("Candidates");
            Id(x => x.Id).Column("CandidateId");
            Map(x => x.Name);
            Map(x => x.IsMale);
            Map(x => x.DateOFBirth);
            Map(x => x.CurrentCTC);
            Map(x => x.CurrentCompany);
            Map(x => x.CandidateType);
            Map(x => x.Address);

            HasMany(x => x.EducationProfileCollection)
  .Inverse()
  .Cascade.AllDeleteOrphan();

            HasMany(x => x.WorkProfileCollection)
 .Inverse()
 .Cascade.AllDeleteOrphan();


        }

    }
}
