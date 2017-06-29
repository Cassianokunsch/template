using ATC.CLN.CDP;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GenericDALImpl<T> : GenericDAL<T> where T : class
    {
        private BDATCEntities context;
        private DbSet<T> _dbSet;

        public GenericDALImpl()
        {
            context = DbConection.getContext();
            _dbSet = context.Set<T>();
        }

        public BDATCEntities getContext()
        {
            return context;
        }

        public void delete(int id)
        {
            var entity = getToId(id);
            if (entity == null) return;
            delete(entity);
        }

        public void delete(T entity)
        {
            var entry = context.Entry(entity);
            _dbSet.Attach(entity);
            entry.State = EntityState.Deleted;
        }

        public IQueryable getAll()
        {
            return _dbSet;
        }

        public T getToId(int id)
        {
            return (T)_dbSet.Find(id);
        }

        public void insert(T entity)
        {
            _dbSet.Add(entity);
            saveChanges();
        }

        public void saveChanges()
        {
            context.SaveChanges();
        }

        public void update(T entity)
        {
            var entry = context.Entry(entity);
            _dbSet.Attach(entity);
            entry.State = EntityState.Modified;
        }
    }
}
