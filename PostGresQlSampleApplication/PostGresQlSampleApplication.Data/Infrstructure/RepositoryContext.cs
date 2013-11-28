using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PostGresQlSampleApplication.Data.Interface;
using System.Data.Entity;

namespace PostGresQlSampleApplication.Data.Infrstructure
{
    public class RepositoryContext : IRepositoryContext
    {

        private const string OBJECT_CONTEXT_KEY = "PostGresQlSampleApplication.Data";
        public IDbSet<T> GetObjectSet<T>()
            where T : class
        {
            return ContextManager.GetObjectContext(OBJECT_CONTEXT_KEY).Set<T>();
        }

        /// <summary>
        /// Returns the active object context
        /// </summary>
        public DbContext ObjectContext
        {
            get
            {
                return ContextManager.GetObjectContext(OBJECT_CONTEXT_KEY);
            }
        }

        public int SaveChanges()
        {
            return this.ObjectContext.SaveChanges();
        }

        public void Terminate()
        {
            ContextManager.SetRepositoryContext(null, OBJECT_CONTEXT_KEY);
        }
    }
}
