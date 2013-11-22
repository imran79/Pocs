using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;

namespace PostgresQlDataSample.Data.Interface
{
    public interface ISessionManager
    {
        ISession Session { get; }
        void CleanUp();
        void Rollback();
        void Commit();
    }
}
