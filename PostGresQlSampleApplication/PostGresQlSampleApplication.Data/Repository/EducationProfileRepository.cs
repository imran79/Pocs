using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PostGresQlSampleApplication.Data.Interface;
using PostGresQlSampleApplication.Data.Infrstructure;
using PostgresQlDataSample.Data.Interface;

namespace PostGresQlSampleApplication.Data.Repository
{
    public class EducationProfileRepository : Repository<EducationProfile>, IEducationProfileRepository
    {

        public EducationProfileRepository()
            : this(new SessionManager<EducationProfile>())
        {


        }

        public EducationProfileRepository(ISessionManager context)
            : base(context)
        {


        }
    }
}
