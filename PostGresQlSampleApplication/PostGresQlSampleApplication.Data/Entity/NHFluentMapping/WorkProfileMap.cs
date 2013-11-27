using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace PostGresQlSampleApplication.Data
{
    public class WorkProfileMap : ClassMap<WorkProfile>
    {
        public WorkProfileMap()
        {
            //Schema("test");
            Table("WorkProfiles");
            Id(x => x.Id).Column("WorkProfileId");
            Map(x => x.Designation);
            Map(x => x.Employer);
            Map(x => x.ReasonForLeaving);
            Map(x => x.Salary);
            Map(x => x.WorkEndDate);
            Map(x => x.WorkStartDate);
            References(x => x.Candidate);

        }
    }
}
