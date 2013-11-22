using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PostGresQlSampleApplication.Data.Interface;
using PostgresQlDataSample.Data.Interface;
using PostGresQlSampleApplication.Data.Infrstructure;

namespace PostGresQlSampleApplication.Data.Repository
{
    public class WorkProfileRepository : Repository<WorkProfile>, IWorkProfileRepository
    {

      public WorkProfileRepository()
            : this(new SessionManager<WorkProfile>())
        {


        }

      public WorkProfileRepository(ISessionManager context)
            : base(context)
        {


        }

    }
}
