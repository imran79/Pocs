using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace PostGresQlSampleApplication.Data.Interface
{
    public interface IRepositoryContext
    {
        /// <summary>
        /// Get Object Collection of that type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IDbSet<T> GetObjectSet<T>() where T : class;

        /// <summary>
        /// Object Context
        /// </summary>
        DbContext ObjectContext { get; }

        /// <summary>
        /// Save all changes to all repositories
        /// </summary>
        /// <returns>Integer with number of objects affected</returns>
        int SaveChanges();

        /// <summary>
        /// Terminates the current repository context
        /// </summary>
        void Terminate();
    }
}
