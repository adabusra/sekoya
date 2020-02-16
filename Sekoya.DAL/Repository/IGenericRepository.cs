using System;
using System.Collections.Generic;
using System.Text;

namespace Sekoya.DAL.Repository
{
  
    interface IGenericRepository<T> where T : class
    {
        void Insert(T entity);
        void Delete(T entity);
        T Find(int entity);
    }
}
