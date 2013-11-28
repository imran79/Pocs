using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PostgresQlDataSample.Data.Interface;
using PostGresQlSampleApplication.Data.Infrstructure;

namespace PostGresQlSampleApplication.Data
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {

        public Repository()
            : this(new SessionManager<T>())
        {
            // if you are going to put the condition here the probability is it will be very hard 
            // to initialize the
        }


        public readonly ISessionManager _sessionManager;

        public Repository(ISessionManager sessionManager)
        {
            _sessionManager = sessionManager;
        }

        /// <summary>
        /// Retrieve an object instance from the database by id.
        /// </summary>
        /// <param name="id">Id of the object to retrieve.</param>
        /// <returns>The object instance to use in the application.</returns>
        public T GetById(int id)
        {
            return _sessionManager.Session.Get<T>(id);
        }

        /// <summary>
        /// Update an object in the database.
        /// </summary>
        /// <param name="objectToUpdate">Object instance containing the information to change in the database.</param>
        public void Update(T objectToUpdate)
        {
            _sessionManager.Session.Update(objectToUpdate);
            _sessionManager.Commit();
        }

        /// <summary>
        /// Create an object in the database.
        /// </summary>
        /// <param name="objectToAdd">Object instance containing the information to add to the database.</param>
        public void Create(T objectToAdd)
        {
            _sessionManager.Session.Save(objectToAdd);
            _sessionManager.Commit();
        }

        /// <summary>
        /// Delete an object from the database.
        /// </summary>
        /// <param name="objectToDelete">Object instance containing the information to delete from the database.</param>
        public void Delete(T objectToDelete)
        {
            _sessionManager.Session.Delete(objectToDelete);
            _sessionManager.Commit();
        }
    }
}
