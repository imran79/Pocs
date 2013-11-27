using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace PostGresQlSampleApplication.Data
{
    public class EducationProfileMap : ClassMap<EducationProfile>
    {

        public EducationProfileMap()
        {
            //Schema("test");
            Table("EducationProfile");
            Id(x => x.Id).Column("EducationProfileId");
            Map(x => x.College);
            Map(x => x.Degree);
            Map(x => x.EndDate);
            Map(x => x.StartDate);
            Map(x => x.percentage);
            References(x => x.Candidate);
        }
    }
}
