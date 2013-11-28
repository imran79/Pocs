using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostgresQlDataSample.Data.Interface
{
    public interface IRepository<T>
    {
        /// <summary>
        /// Creating object of type t
        /// </summary>
        /// <param name="objectToAdd"></param>
        void Create(T objectToAdd);
        /// <summary>
        /// Retriving Object Of Type T
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetById(int id);
        /// <summary>
        /// Updating Object Of Type T
        /// </summary>
        /// <param name="objectToUpdate"></param>
        void Update(T objectToUpdate);
        /// <summary>
        /// Deleting Object Of Type T
        /// </summary>
        /// <param name="objectToDelete"></param>
        void Delete(T objectToDelete);
    }
}
