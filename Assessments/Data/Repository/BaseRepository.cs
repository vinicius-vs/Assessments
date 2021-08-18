using Data.ContextDb;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public abstract class BaseRepository<T> where T : Base
    {
        public virtual void Create(T model)
        {
            using (var context = new AssessmentsDb())
            {
                context.Set<T>().Add(model);
                context.SaveChanges();
            }
        }
        public virtual List<T> Read()
        {
            using (var context = new AssessmentsDb())
            {
                return context.Set<T>().ToList();
            }
        }
        public virtual T Read(int id)
        {
            using (var context = new AssessmentsDb())
            {
                return context.Set<T>().Find(id);
            }
        }
        public virtual void Update(T model)
        {
            using (var context = new AssessmentsDb())
            {
                context.Entry<T>(model).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public virtual void Delete(int id)
        {
            using (var context = new AssessmentsDb())
            {
                context.Entry<T>(this.Read(id)).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
