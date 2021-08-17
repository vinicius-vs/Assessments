using Data.ContextDb;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public abstract class BaseRepository<T> where T : Base
    {
        public void Create(T model)
        {
            using (var context = new AssessmentsDb())
            {
                context.Set<T>().Add(model);
            }
        }
        public List<T> Read()
        {
            List<T> list = new List<T>();
            using (var context = new AssessmentsDb())
            {
                return list = context.Set<T>().ToList();
            }
        }
        public T Read(int id)
        {
            T model = Activator.CreateInstance<T>();
            using (var context = new AssessmentsDb())
            {
                model = context.Set<T>().Find(id);
            }
            return model;
        }
        public void Delete(int id)
        {
            using (var context = new AssessmentsDb())
            {
                context.Entry<T>(this.Read(id)).State = System.Data.Entity.EntityState.Deleted;
            }
        }
    }
}
