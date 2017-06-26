using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    interface GenericDAL<T> where T : class
    {
        IQueryable getAll();
        T getToId(int id);
        void insert(T entity);
        void update(T entity);
        void delete(T entity);
        void delete(int id);
        void saveChanges();
    }
}
