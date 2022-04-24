using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiparisOtomasyon.DAL.Abstract
{
    using Context;
    using System.Data.Entity;
    //T tipi nesnenin tipi
    //T1 tipi customer tablosu özelinde yazılmış ID için belirtilen tip
    public class GenericRepo<T, T1> : IReporsitory<T, T1>
        where T : class // T tipi referans tipli bir nesne tipinde olması gerekir
    {
        private NorthwndContext _DB;
        public NorthwndContext DB
        {
            get
            {
                if (_DB == null)
                    _DB = new NorthwndContext();
                return _DB;
            }
        }
        public virtual void Add(T item)
        {
            DB.Set<T>().Add(item);
            DB.SaveChanges();
        }

        public virtual bool Delete(T1 Id)
        {
            var dbItem = DB.Set<T>().Find(Id);
            if (dbItem != null)
            {
                DB.Set<T>().Remove(dbItem);
                DB.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual List<T> Get()
        {
            return DB.Set<T>().AsNoTracking().ToList();
        }

        public  virtual T GetById(T1 Id)
        {
            return DB.Set<T>().Find(Id);
        }

        public void Update(T item)
        {
            DB.Entry<T>(item).State = EntityState.Modified;
            DB.SaveChanges();
        }
    }
}
