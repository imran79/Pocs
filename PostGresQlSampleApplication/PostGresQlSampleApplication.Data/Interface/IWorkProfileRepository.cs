using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PostgresQlDataSample.Data.Interface;

namespace PostGresQlSampleApplication.Data.Interface
{
    public interface IWorkProfileRepository : IRepository<WorkProfile>
    {
    }
}
