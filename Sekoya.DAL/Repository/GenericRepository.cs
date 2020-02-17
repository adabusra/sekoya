using Microsoft.EntityFrameworkCore;
using Sekoya.DAL.Constants;
using Sekoya.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sekoya.DAL.Repository
{

    public class GenericRepository<T> : IGenericRepository<T>
      where T : class
    {
        DbContext context;
        public GenericRepository()
        {
            context = new SEKOYAContext();
        }
        public virtual void Insert(T model)
        {
            try
            {
                context.Set<T>().Add(model);
                context.SaveChanges();
            }
            catch (Exception e)
            {
                var error = e.Message;
                ErrorHandler errorFile = new ErrorHandler();
                ErrorHandler.Instance.Add(e.Message,e);
            }
        }
        public virtual void Delete(T model)
        {
            context.Remove(model);
            context.SaveChanges();
        }

        public virtual T Find(int id)
        {
             return context.Set<T>().Find(id);
        }
    }
}
