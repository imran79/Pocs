using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;

namespace PostgresQlDataSample.Data.Interface
{
    public interface ISessionManager
    {
        /// <summary>
        /// Session
        /// </summary>
        ISession Session { get; }
        /// <summary>
        /// Clean Up
        /// </summary>
        void CleanUp();
        /// <summary>
        ///  Rollback
        /// </summary>
        void Rollback();
        /// <summary>
        /// Commit
        /// </summary>
        void Commit();
    }
}
