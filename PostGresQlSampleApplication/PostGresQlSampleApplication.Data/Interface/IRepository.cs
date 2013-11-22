using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostgresQlDataSample.Data.Interface
{
    public interface IRepository<T>
    {
        void Create(T objectToAdd);
        T RetrieveById(int id);
        void Update(T objectToUpdate);
        void Delete(T objectToDelete);
    }
}
