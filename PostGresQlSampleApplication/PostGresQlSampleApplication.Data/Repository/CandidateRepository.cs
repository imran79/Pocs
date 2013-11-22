using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PostGresQlSampleApplication.Data.Interface;
using PostGresQlSampleApplication.Data.Infrstructure;
using PostgresQlDataSample.Data.Interface;

namespace PostGresQlSampleApplication.Data.Repository
{
    public class CandidateRepository : Repository<Candidate>, ICandidateReposiotry
    {

        public CandidateRepository()
            : this(new SessionManager<Candidate>())
        {


        }

        public CandidateRepository(ISessionManager context)
            : base(context)
        {


        }
    }
}
