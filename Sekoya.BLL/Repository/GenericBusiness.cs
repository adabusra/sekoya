using Sekoya.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sekoya.BLL.Repository
{
    public abstract class GenericBusiness<T> where T : class
    {
        GenericRepository<T> repo = new GenericRepository<T>();

        public void Insert(T entity)
        {
            repo.Insert(entity);
        }
       

    }
}
